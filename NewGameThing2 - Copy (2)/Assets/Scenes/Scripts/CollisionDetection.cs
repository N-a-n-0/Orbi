using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    //public AudioSource audio;

    public GameObject ball;
	 public static DropDownSelect fr;
     //public int funnytwo = fr.returnfunny();

	//public int bruh = int.TryParse(fr.bruhbruh);
	public AudioSource _as;
    public AudioClip[] audioClipArray;
    
    public TMPro.TMP_Dropdown myDrop; 
    
public Pause pause;
    //public int bruh = new DropDownSelect().myDrop.value;

	void Awake()
    {
        _as = GetComponent<AudioSource> ();
        
        
    }



    void Start()
    {
        //audio = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {

            _as.clip = audioClipArray[myDrop.value];
            _as.PlayOneShot(_as.clip);

            /* if (myDrop.value == 0)
             {
                 print("cringe");
             }
             else if (myDrop.value == 1) 
             {
                 print("small based");
             }
           */


	
            //Random.Range(0,audioClipArray.Length)

        }

    }


    

}

