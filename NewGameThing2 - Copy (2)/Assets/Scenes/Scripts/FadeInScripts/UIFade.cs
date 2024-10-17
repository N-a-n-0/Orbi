using System.Collections;

using UnityEngine;


public class UIFade : MonoBehaviour
{

    private bool isFading = false;

    public CanvasGroup MainMenu;
    public CanvasGroup CreditsMenu;
   

    public GameObject Credits;
  
    IEnumerator FadeFromTo(float from, float to)
    {
        isFading = true;
        var curve = new AnimationCurve(new Keyframe[]
        {
            new Keyframe(0f, from),
            new Keyframe(1f, to)
        });

        float time = 0f;

        while (time < 1f)
        {
            MainMenu.alpha = curve.Evaluate(time);
            time += 0.5f * Time.deltaTime;
            yield return null;
        }


        MainMenu.alpha = curve.Evaluate(1f);

        isFading = false;
    }


    IEnumerator FadeFromToNewMenu(float from, float to, CanvasGroup PreviousMenu, CanvasGroup CurrentMenu)
    {
        PreviousMenu.blocksRaycasts = false;
        isFading = true;
        var curve = new AnimationCurve(new Keyframe[]
        {
            new Keyframe(1f, from),
            new Keyframe(0f, to)
        });

        float time = 1f;

        while (time > 0f)
        {
            PreviousMenu.alpha = curve.Evaluate(time);
            time -= 0.5f * Time.deltaTime;
            yield return null;
        }


        PreviousMenu.alpha = curve.Evaluate(0f);



        var curveSecond = new AnimationCurve(new Keyframe[]
       {
            new Keyframe(1f, from),
            new Keyframe(0f, to)
       });


        while (time < 1f)
        {
            CurrentMenu.alpha = curveSecond.Evaluate(time);
            time += 0.5f * Time.deltaTime;
            yield return null;
        }

        CurrentMenu.alpha = curveSecond.Evaluate(1f);

        isFading = false;

        CurrentMenu.blocksRaycasts = true;
    }


  //  void Start()
  //  {
  //      StartCoroutine(FadeFromTo(0, 1f));
   // }

   

    public void CreditsButton()
    {
        if (isFading == false)
        {
            Credits.SetActive(true);
            StartCoroutine(FadeFromToNewMenu(1f, 0, MainMenu, CreditsMenu));
        }
    }

    public void CreditsToMainMenu()
    {
        if (isFading == false)
        {
            StartCoroutine(FadeFromToNewMenu(1f, 0, CreditsMenu, MainMenu));

        }
    }
  


}
