using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {
	public GameObject followedObject; 

	void Update () {  
		transform.position = new Vector3 (followedObject.transform.position.x, followedObject.transform.position.y, 10);
	}
}
