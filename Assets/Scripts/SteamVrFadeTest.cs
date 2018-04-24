using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamVrFadeTest : MonoBehaviour {

	private float _fadeDuration = 5f;

	private void Start()
	{
		FadeToBlack();
		//Invoke("FadeFromBlack", _fadeDuration);
	}
	public void FadeToBlack()
	{
		Debug.Log ("Fade");
		//set start color
		SteamVR_Fade.Start(Color.clear, 0f);
		//set and start fade to
		SteamVR_Fade.Start(Color.black, _fadeDuration);
	}
	private void FadeFromBlack()
	{
		Debug.Log ("Fade2");
		//set start color
		SteamVR_Fade.Start(Color.black, 0f);
		//set and start fade to
		SteamVR_Fade.Start(Color.clear, _fadeDuration);
	}
}

