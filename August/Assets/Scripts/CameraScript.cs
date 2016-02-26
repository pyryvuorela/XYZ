using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject followedObject;
	public float followingSpeed;
    public int Zoffset;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {  
		float speed = followingSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position,new Vector3(followedObject.transform.position.x, followedObject.transform.position.y, Zoffset), speed);
	}
}
