using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
	public AudioSource sound;
	public GameObject bruh;
    // Start is called before the first frame update
    void Start()
    {
	    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Intro Spalsh"))
	    {
		    StartCoroutine(load());
		    load(); 
	    }
	    else
	    {
		    StartCoroutine(load1());
		    load1();   
	    }


    }

    IEnumerator load()
    {
		sound.Play();
        yield return new WaitForSeconds(8);
        bruh.GetComponent<FadeScenes>().BeginFade(1);
        yield return new WaitForSeconds(1.75f);
		SceneLoader.LoadSceneByName("VidThing");
    }
    
    IEnumerator load1()
    {
	    sound.Play();
	    yield return new WaitForSeconds(8);
	    bruh.GetComponent<FadeScenes>().BeginFade(1);
	    yield return new WaitForSeconds(1.75f);
	    SceneLoader.LoadSceneByName("MainScene");
    }
}
