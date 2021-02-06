using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour {

	public Texture backgroundTexture;

	void Start () {
		StartCoroutine("Countdown");
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	void Update (){


	}

	private IEnumerator Countdown () {

		yield return new WaitForSeconds (9);
		Application.LoadLevel ("mainmenu");

	}

	void OnGUI () {

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
	}
}