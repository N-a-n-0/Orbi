using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinScript : MonoBehaviour
{
    public TextMeshProUGUI changingText;
	public TextMeshProUGUI WinTextScore;
	public GameObject PanelWin;
    public static int Score = 0;
	public GameObject st1;
	public GameObject st2;
	public GameObject st3;
    public Rigidbody2D rigid;
	public GameObject LevelText;	
   
    // Start is called before the first frame update
    void Start()
    {
				Score = 0;
       			st1.SetActive(false);
				st2.SetActive(false);
				st3.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Square" || col.gameObject.tag == "Triangle")
        {
            Score = Score + 5;
            changingText.text = "Score: " + Score;
            Debug.Log("The Ball collided with something with the tag BRUH give them 5 points bro");
        }
            
		 if (col.gameObject.tag == "Win")
		 {
			 //GameObject.Find("load").GetComponent<WaitForStuff>().WinLoad();
			 LevelText.SetActive(false);
			 PanelWin.SetActive(true);
			if(Score <= 20)
			{
				st1.SetActive(true);
			}
			else if(Score > 20 && Score <= 30)
			{
				st1.SetActive(true);
				st2.SetActive(true);
			}
			else
			{
				st1.SetActive(true);
				st2.SetActive(true);
				st3.SetActive(true);

			}
           
            WinTextScore.text = "You Win! :D";
            Debug.Log("The Ball collided with something with the tag BRUH give them 5 points bro");
			rigid = GetComponent<Rigidbody2D>();
        rigid.constraints = RigidbodyConstraints2D.FreezeAll;
		//PlayerPrefs.SetInt("max", PlayerPrefs.GetInt("max") + 1);
		//PlayerPrefs.SetInt("levelAt", PlayerPrefs.GetInt("levelAt") + 1);
        winHandle bruh = new winHandle(); 
		bruh.checkWin();
		
		
        
        //Time.timeScale=0;
        }
   
    }

	public static void setZero()
	{
		Score = 0;

	}
}
