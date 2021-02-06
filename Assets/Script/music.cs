using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

	public AudioSource src;
	// Use this for initialization
	public void PlayMusic()
	{
		src.Play();
	}

	public void PauseMusic()
	{
		src.Pause();
	}

}
