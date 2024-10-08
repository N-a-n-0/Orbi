using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Create : MonoBehaviour
{

    public GameObject Shape;
	public GameObject deez;
	public TMPro.TMP_Dropdown myDrop; 
	public GameObject ball;
	public GameObject triangle;

	public GameObject bounce;

	public float speed = 1.5f;

	public GameObject placeHolder;
	//Vector2 pos = new Vector2(GameObject.Find("SquareTest").transform.position.x, GameObject.Find("SquareTest").transform.position.y);
    
    Vector2 CircleSpawn = new Vector2();
	    //-8, 4
    Vector2 pos = new Vector2();
	Vector2 tri = new Vector2();
    
    // Update is called once per frame
    
    void Update()
    {
	    pos.x = placeHolder.transform.position.x;
	    pos.y = placeHolder.transform.position.y;
	    CircleSpawn.x = placeHolder.transform.position.x;
	    CircleSpawn.y = placeHolder.transform.position.y;
		tri.x = placeHolder.transform.position.x;
	    tri.y = placeHolder.transform.position.y;
    transform.position = Vector2.MoveTowards(transform.position, ball.transform.position, speed * Time.deltaTime);
			transform.up = ball.transform.position - transform.position;
			//print(placeHolder.transform);
    }
    public void Bruh()
    {
	    
        
			Vector2 pos = new Vector2(GameObject.Find("SpawnHolderSQUARE").transform.position.x, GameObject.Find("SpawnHolderSQUARE").transform.position.y);

            var newObj = GameObject.Instantiate(Shape,pos, Shape.transform.rotation) ;
            newObj.transform.parent = GameObject.Find("Object Holder").transform;
            
        
    }

	public void Bruh2()
    	{
	        
        
		Vector2 pos = new Vector2(GameObject.Find("SpawnHolderCIRCLE").transform.position.x, GameObject.Find("SpawnHolderCIRCLE").transform.position.y);

            var newObj = GameObject.Instantiate(deez,pos, deez.transform.rotation) ;
            newObj.transform.parent = GameObject.Find("Object Holder").transform;
			
			//transform.Translate(bruh);
        
    	}
	public void Bruh3()
		{
		Vector2 pos = new Vector2(GameObject.Find("SpawnHolderTRIANGLE").transform.position.x, GameObject.Find("SpawnHolderTRIANGLE").transform.position.y);
			var newObj = GameObject.Instantiate(triangle,pos, triangle.transform.rotation) ;
            newObj.transform.parent = GameObject.Find("Object Holder").transform;
			


		}
	
	public void Bruh4()
	{
		Vector2 pos = new Vector2(GameObject.Find("SpawnHolderBouncy").transform.position.x, GameObject.Find("SpawnHolderBouncy").transform.position.y);
		var newObj = GameObject.Instantiate(bounce,pos, bounce.transform.rotation) ;
		newObj.transform.parent = GameObject.Find("Object Holder").transform;
			


	}

}
