using UnityEngine;
using System.Collections;

public class BorderExitScript : MonoBehaviour {
	public int level;

	void OnTriggerExit2D(Collider2D other) {
		Application.LoadLevel(level);
	}
}
