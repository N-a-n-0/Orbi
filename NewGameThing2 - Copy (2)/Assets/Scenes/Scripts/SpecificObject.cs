using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificObject : SaveableObject
{

    private float Note;


   

    // Update is called once per frame
    void Update()
    {
		if(Input.GetButtonDown("Fire2"))
		{
			//DestroySaveable();
		}
		
      //  GameObject gm = null;
        //gm.GetComponent<SaveGameManager>().Save();

    }

    public override void  Save(int id)
    {
		
        base.Save(id);
    }

    public override void Load(string[] values)
    {
        base.Load(values);
    }

}
