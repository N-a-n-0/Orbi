using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Button[] lvlButtons;
    
    public void Update()
    {
	    int levelAt = PlayerPrefs.GetInt("levelAt", 0);
	    int max = PlayerPrefs.GetInt("max", 1) ;

	    if (Input.GetKeyDown("space"))
	    {
		    PlayerPrefs.SetInt("levelAt", 0);
		    PlayerPrefs.SetInt("max", 1);

	    }

    }


    void Start()
    {
	    if (PlayerPrefs.GetInt("max") >= 1)
	    {



		    for (int i = 0; i < lvlButtons.Length; i++)
		    {

			    Debug.Log("levelAt : " + PlayerPrefs.GetInt("levelAt"));
			    Debug.Log("max : " + PlayerPrefs.GetInt("max"));
			    if (i >= PlayerPrefs.GetInt("max"))
				    lvlButtons[i].interactable = false;
		    }
	    }
	    else
	    {
		    PlayerPrefs.SetInt("levelAt", 0);
		    PlayerPrefs.SetInt("max", 1);
	    }


    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1.0f;
    }

    public static void LoadLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
        Time.timeScale = 1.0f;
    }
    
    public static void LoadSceneByName(string sceneName)
    {
	//float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		//yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName);

        Time.timeScale = 1.0f;
		
    }

	 public static void OtherSceneLoad(string sceneName)
    {
	//float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		//yield return new WaitForSeconds(2);

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
		
    }
}
