using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using TMPro;



public class LightIntensity : MonoBehaviour
{
	public TMP_Text free;  
	public TMP_Text level;  
    public Light2D light;
    //private Rigidbody2D player;

    public void lightupfree()
    {
		free.color = new Color(0, 61, 165, 255);
    }
    public void lightuplevel()
    {
	    level.color = new Color(0, 61, 165, 255);

    }
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {

            //light = GetComponent<Light2D>();
            light.intensity = 1.1f;
            

        }

    }


	public void Update()
	{
			if(light.intensity >= .29f)
			{
			light.intensity = light.intensity - .001f;
			}
				

	}
}
