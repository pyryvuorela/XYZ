using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {
	public GameObject music;
	void Awake() {
		DontDestroyOnLoad(music);
	}
}
