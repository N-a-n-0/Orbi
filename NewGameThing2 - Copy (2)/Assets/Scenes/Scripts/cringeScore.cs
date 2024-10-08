using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class cringeScore : MonoBehaviour
{
    public TextMeshProUGUI changingText;
	public TextMeshProUGUI WinTextScore;
public GameObject PanelWin;
    public int Score = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BRUH")
        {
            Score = Score + 5;
            changingText.text = "Score: " + Score;
            Debug.Log("The Ball collided with something with the tag BRUH give them 5 points bro");
        }
            
		 if (col.gameObject.tag == "YOUISWINNER")
        {
			 PanelWin.SetActive(true);
           
            WinTextScore.text = "Score: " + Score;
            Debug.Log("The Ball collided with something with the tag BRUH give them 5 points bro");
        }
        
    }
    
}
