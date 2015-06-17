using UnityEngine;
using System.Collections;

public class CameraB : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.parent = Camera.main.transform;
	}
}
