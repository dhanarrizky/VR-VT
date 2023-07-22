using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class SplashFade : MonoBehaviour {
	public Image splashImage;
	public string loadlevel;


	IEnumerator Start()
	{
		splashImage.canvasRenderer.SetAlpha (0.0f);
		FadeIn ();
		yield return new WaitForSeconds (1f);
		FadeOut ();
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (loadlevel);

	}

	void FadeIn()
	{
		splashImage.CrossFadeAlpha (2.5f, 2.5f, false);
	}

	void FadeOut()
	{
		splashImage.CrossFadeAlpha (0.0f, 2.5f, false);
	}




}
