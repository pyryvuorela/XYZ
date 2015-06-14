using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject target;
	public float xOffset = 0;
	public float yOffset = 0;
	public float zOffset = 0;

	void LateUpdate() {
		this.transform.position = new Vector3 (target.transform.position.x + xOffset,target.transform.position.y + yOffset,
		                                       target.transform.position.z + zOffset);
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
