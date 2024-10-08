using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool  RightClicked = false;
    public bool MiddleClicked = false;

    public SaveableObject SObj;
    public GameObject PitchDropDown;


	
    // Update is called once per frame
    void Update()
    {
        


        if (MiddleClicked == true  )
        {
            PitchDropDown.SetActive(true);
            MiddleClicked = false;
        }
        
        
         


        if (RightClicked == true)
        {


            Destroy(gameObject);
			
            
        }

    }

    void OnMouseOver()
    {


        //Check to see if the tag on the collider is equal to Enemy
        if (Input.GetButtonDown("Fire3") && tag == "Square")
        {
            MiddleClicked = true;
            print("MiddleClicked");
        }

		if (Input.GetButtonDown("Fire3") && tag == "Circle")
        {
            MiddleClicked = true;
            print("MiddleClicked");
        }
        
        if (Input.GetButtonDown("Fire3") && tag == "Triangle")
        {
            MiddleClicked = true;
            print("MiddleClicked");
        }
        
        if (Input.GetButtonDown("Fire3") && tag == "Bouncy")
        {
            MiddleClicked = true;
            print("MiddleClicked");
        }

		




        if (Input.GetButtonDown("Fire2"))
        {
            RightClicked = true;
            print("RightClicked");
        }






    }
}


