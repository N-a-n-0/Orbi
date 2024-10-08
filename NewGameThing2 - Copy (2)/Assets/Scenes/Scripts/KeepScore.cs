using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class KeepScore : MonoBehaviour
{
    public TextMeshProUGUI changingText;
    public int Score = 0;
    public GameObject changingTextTwo;
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
            
        
    }
    
}
