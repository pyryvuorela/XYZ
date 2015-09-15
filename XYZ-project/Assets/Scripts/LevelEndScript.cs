using UnityEngine;
using System.Collections;

public class LevelEndScript : MonoBehaviour {
	public int ScenenValinta = 0;

	void OnTriggerEnter2D(Collider2D other) {
		Application.LoadLevel(ScenenValinta);
	}
}