using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerAudio : MonoBehaviour
{
    public static AudioSource music;
    void Start()
    {
        music = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void lowerSound()
    {
        StartCoroutine(sound());
    }


    IEnumerator sound()
    {
        float i = 0f;
        while (music.volume != i)
        {
            music.volume = music.volume - .05f;
            yield return new WaitForSeconds(.1f);
        }  
    }
  /*  public static void lower()
    {
        float i = 0f;
        while (music.volume != i)
        {
            music.volume--;
        }
        

    }
    */
}
