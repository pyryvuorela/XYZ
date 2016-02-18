﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]
public class PlayMovie : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;

	void Start () {
		GameControl.control.videoPolicy = true;
		if (GameControl.control.videoPolicy == true) {
			GetComponent<RawImage> ().texture = movie as MovieTexture;
			audio = GetComponent<AudioSource> ();
			audio.clip = movie.audioClip;
			movie.Play ();
			audio.Play ();
		}
	}	

	void Update () {
	
	}
}
