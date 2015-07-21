using UnityEngine;
using System.Collections;

public class LevelEndScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Application.LoadLevel(1);
	}
}