using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class SaveGameManager : MonoBehaviour
{
	
	
	public TMPro.TMP_Dropdown drop;

	public TMPro.TMP_Dropdown drop3;  

	public TMPro.TMP_Dropdown drop2; 

	public Camera cam; 	

	public float speed = 10000.0f;

    private static SaveGameManager instance;

    public List<SaveableObject> SaveableObjects { get; private set; }

    private List<Vector3> pos = new List<Vector3>();

	private List<TMPro.TMP_Dropdown> balls = new List<TMPro.TMP_Dropdown>();

	public bool thing = false;

	private Transform cords = new RectTransform();
	
	//public Transform canvas;

	public static SaveGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<SaveGameManager>();
            }
            return instance;
        }
    }

    void Awake()
    {
		
        SaveableObjects = new List<SaveableObject>();
        cords = GameObject.Find("Object Holder").transform;
        cords.transform.position = new Vector3(0, 0, 0);//cam.ScreenToWorldPoint(cords.transform.position); //new Vector3(-549.5f, -309f, 0f);
    }

    public void Save()
    {
		PlayerPrefs.DeleteAll();
	    checkNull();

        PlayerPrefs.SetInt("ObjectCount", SaveableObjects.Count);
		if(balls.Count != 0)
		{
		 balls.Clear();
		 pos.Clear();
		 checkNull();
		}
         for (int i = 0; i < SaveableObjects.Count; i++)
         {
			 checkNull();
	         //myDrop = GameObject.Find("Dropdown2").GetComponent<TMPro.TMP_Dropdown>();
	         SaveableObjects[i].Save(i);
			 
			balls.Add(SaveableObjects[i].transform.GetChild(0).gameObject.GetComponent<TMPro.TMP_Dropdown>());
		 pos.Add(SaveableObjects[i].transform.position);
print(pos[i]);
         }
		 checkNull();

		

    }
    

  

    public void Load()
    {
		checkNull();
		checkNull();
		int objectCount = PlayerPrefs.GetInt("ObjectCount");
        foreach (SaveableObject obj in SaveableObjects)
        {
            if (obj != null)
            {
                Destroy(obj.gameObject);
            }
        }

        SaveableObjects.Clear();


        
 			
            for(int i = 0; i < objectCount; i++)
            {


	            string[] value = PlayerPrefs.GetString(i.ToString()).Split('_');

            GameObject tmp = null;
			//print(balls[i].GetComponent<TMPro.TMP_Dropdown>());
            switch(value[0])
            {
            case "Triangle":
                     tmp = Instantiate(Resources.Load("Triangle") as GameObject);
					 tmp.transform.parent = GameObject.Find("Object Holder").transform;
                     //tmp.transform.GetChild(0).parent = GameObject.Find("DropDownHolding").transform;
                     //tmp.transform.position = cam.ScreenToWorldPoint(tmp.transform.position);
					 //transform.position = Vector2.MoveTowards(transform.position, tmp.transform.position, speed * Time.deltaTime);
					 
					 //tmp.transform.position.Set(pos[0].x, pos[0].y, pos[0].z);
					 //Vector2 screenPos = cam.WorldToScreenPoint(tmp.transform.position);
					 //print(pos[0]);
					 if(tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value == drop3.value)
					 {	
					 	tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value = balls[i].value;
					 }
					 tmp.GetComponent<SaveableObject>().Load(value);
					 checkNull();
					 tmp = null;
                break;
            case "Circle":
                     tmp = Instantiate(Resources.Load("Circle") as GameObject);
					 tmp.transform.parent = GameObject.Find("Object Holder").transform;
					 //myDrop = GameObject.Find("Dropdown2").GetComponent<TMPro.TMP_Dropdown>();
					// drop2.value = i;
					 if(tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value == drop2.value)
					 {	
					 	tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value = balls[i].value;
					 }
					 tmp.GetComponent<SaveableObject>().Load(value);
					 checkNull();
					 tmp = null;
                break;
            case "Square":
                     tmp = Instantiate(Resources.Load("Square") as GameObject);
					 tmp.transform.parent = GameObject.Find("Object Holder").transform;
					 if(tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value == drop.value)
					 {	
					 	tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value = balls[i].value;
					 }
					 tmp.GetComponent<SaveableObject>().Load(value);
					 checkNull();
					 tmp = null;
                    break;
            
            case "Bouncy":
	            tmp = Instantiate(Resources.Load("Bouncy") as GameObject);
	            tmp.transform.parent = GameObject.Find("Object Holder").transform;
	            if(tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value == drop.value)
	            {	
		            tmp.transform.GetChild(0).GetComponent<TMPro.TMP_Dropdown>().value = balls[i].value;
	            }
	            tmp.GetComponent<SaveableObject>().Load(value);
	            checkNull();
	            tmp = null;
	            break;


            }

Debug.Log(value);
            }

    }


    public Vector3 StringToVector(string value)
    {
        //(1, 23, 3);
        value = value.Trim(new char[] { '(', ')' });


        //1, 23, 3
        value = value.Replace(" ", "");

        //1,23,3
        string[] pos = value. Split(',');

        //[0] = 1 [1] = 23 [2] = 3

        return new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));


   
       
    }
	
	public void checkNull()
	{
		for(int i = 0; i < SaveableObjects.Count; i++ )
		{
		 	if(SaveableObjects[i] == null)
			{
			 balls.RemoveAt(i);


			 SaveableObjects.RemoveAt(i);
			 
			}


		}
	}

    public Quaternion StringToQuaternion(string value)
    {
          //(1, 23, 3);
        value = value.Trim(new char[] { '(', ')' });


        //1, 23, 3
        value = value.Replace(" ", "");

        //1,23,3
        string[] pos = value. Split(',');

        //[0] = 1 [1] = 23 [2] = 3

        return new Quaternion(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]), float.Parse(pos[3]));
    }


}
