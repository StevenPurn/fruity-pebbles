using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SplashFade : MonoBehaviour
{

    public Image splashImage;
    public string loadGame;
    void Start() {
        Debug.Log("starting");
        StartCoroutine(FadeCanvas());
    }

    IEnumerator FadeCanvas()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadGame);

    }
    void FadeIn()
    {
        Debug.Log("fade");
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void FadeOut()
    {
        Debug.Log("fade");
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
