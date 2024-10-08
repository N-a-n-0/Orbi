using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaitForStuff : MonoBehaviour
{
    public TextMeshProUGUI lvlText;
	public string textChange;
	public string lvls;
	public AudioSource bruh;
	//public string deadScene = "";

	//public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(txt(lvlText));
    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.deltaTime);
    }

	public void waitfor()
	{
		StartCoroutine(Wait());
	}

	public void waitforMore()
	{
		StartCoroutine(WaitMore());
	}

	public void waitevenMore()
	{
		StartCoroutine(WaitEvenMore());
	}

	public void OtherScene()
	{
		StartCoroutine(OtherSceneLoad());
	}

	public void level()
	{
		StartCoroutine(lvl());
	}

	public void deadReload(string deadScene)
	{
		StartCoroutine(dead(deadScene));
	}

	public void text(TextMeshProUGUI lvlText)
	{
		StartCoroutine(txt(lvlText));
	}

	public void WinLoad()
	{
		StartCoroutine(win());
	}
	
	public void betaLoad()
	{
		StartCoroutine(beta());
	}


	IEnumerator Wait()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);
		SceneLoader.LoadMainMenu();
	}

	IEnumerator WaitMore()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);
		SceneLoader.LoadLevelSelect();

	}

	IEnumerator WaitEvenMore()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);
		SceneLoader.LoadSceneByName("VidThing");

	}

	IEnumerator OtherSceneLoad()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);

	}

		IEnumerator lvl()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);
		SceneLoader.LoadSceneByName(lvls);

	}

		IEnumerator dead(string deadScene)
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
		yield return new WaitForSeconds(2);
		SceneLoader.LoadSceneByName(deadScene);

	}

		IEnumerator txt(TextMeshProUGUI text)
	{		
		string display = "";
		
		yield return new WaitForSeconds(2);
		bruh.Play();
		for(int i = 0; i < textChange.Length; i++)
			{
				display = textChange.Substring(0, i + 1);
				lvlText.text = display;
				//bruh.volume = Random.Range(.1f, .5f);
				//bruh.Play();
				yield return new WaitForSeconds(.1f);				

			}
			bruh.Pause();


/*
		for(int i = 0; i < lvlText.text.Length; i++)
			{
				display += lvlText.text.Substring(i, i + 1);
				lvlText.text = display;
				yield return new WaitForSeconds(1);				

			}
*/




/*
		yield return new WaitForSeconds(5);
		lvlText.text = textChange;
		yield return new WaitForSeconds(20);		
		lvlText.text = "";
*/
	}
		IEnumerator win()
		{
			yield return new WaitForSeconds(2);
			float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
			


		}
		
		IEnumerator beta()
		{
			float fadeTime = GameObject.Find("Main Camera").GetComponent<FadeScenes>().BeginFade(1);
			yield return new WaitForSeconds(2);
			SceneLoader.LoadSceneByName("BETA SPALSH");
			


		}

}
