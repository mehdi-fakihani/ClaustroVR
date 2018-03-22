using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour {
    public Image FadeImg;
    public float fadeSpeed = 1.5f;

    // Update is called once per frame
    void Update () {
		
	}

    public void EndScene()
    {
        StartCoroutine(FadeToBlack());
    }

    IEnumerator FadeToBlack()
    {
        FadeImg.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
        FadeImg.color = Color.clear;
        FadeImg.enabled = true;

        float step = fadeSpeed * Time.deltaTime;
        while (FadeImg.color.a < 1f)
        {
            FadeImg.color = Color.Lerp(FadeImg.color, Color.black, step);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
