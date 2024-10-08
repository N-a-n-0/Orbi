using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	public GameObject dead;
    public GameObject pauseMenu;
	public GameObject pauseMenudos;
    public RigidbodyConstraints2D bruh;
    public Rigidbody2D rigid;
	private bool br;
	public GameObject ball;
    // Start is called before the first frame update
    public void Pausebruh()
    {
        pauseMenu.SetActive(true);
        //Time.timeScale = 0f;
        rigid = GetComponent<Rigidbody2D>();
        rigid.constraints = RigidbodyConstraints2D.FreezeAll;

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "OutOfBounds" )
        {
			Debug.Log("The Ball collided with something with the tag OutOfBounds give them 5 points bro");
			
			ball.GetComponent<TimeBody>().StartRewind();
			Pausebruh();
			
			DragOff.DOn();
        }

		  if (col.gameObject.tag == "EnemyBall" )
        {
			Debug.Log("The Ball collided with something with the tag EnemyBall why so serious");
			Pausebruh();
			dead.GetComponent<WaitForStuff>().deadReload(SceneManager.GetActiveScene().name);
		}
    }


    // Update is called once per frame
    public void Resume()
    {
        pauseMenu.SetActive(true);
        //Time.timeScale = 1f;
        //rigid = GetComponent<Rigidbody2D>();
        rigid.constraints = RigidbodyConstraints2D.None;

    rigid.AddForce(transform.up * 1f);
    }


	public void otherPause()
	{
		if(br == false)
		{
		 pauseMenudos.SetActive(true);
		Time.timeScale = 0f;
		br = true;
		}
		else if(br == true)
		{
		pauseMenudos.SetActive(false);
		Time.timeScale = 1f;
		br = false;
		}
	
	}

	public void Home()
	{
		Time.timeScale = 1f;
		pauseMenudos.SetActive(true);
		SceneManager.LoadScene("MainScene");
	}
	
	
      
        
    

}




