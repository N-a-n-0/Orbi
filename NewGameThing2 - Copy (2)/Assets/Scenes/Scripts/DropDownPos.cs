using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownPos : MonoBehaviour
{
    //public TMPro.TMP_Dropdown myDrop;
	public GameObject bruh1;
	public float speed = 10000.0f;
	//public Transform target ;
	public Camera cam; 

		
    // Start is called before the first frame update
    void Start()
    {
         	cam = Camera.main;
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = cam.WorldToScreenPoint(bruh1.transform.position);
        //Debug.Log("target is " + screenPos.x + " pixels from the left");

        transform.position = Vector2.MoveTowards(transform.position, screenPos, speed * Time.deltaTime);
			//transform.up = bruh1.transform.position - transform.position;
    }

    public void thing()
    {
	    cam = Camera.main;
	    Vector2 screenPos = cam.WorldToScreenPoint(bruh1.transform.position);
	    //Debug.Log("target is " + screenPos.x + " pixels from the left");

	    transform.position = Vector2.MoveTowards(transform.position, screenPos, speed * Time.deltaTime);
	    //transform.up = bruh1.transform.position - transform.position;
	    
    }
}
