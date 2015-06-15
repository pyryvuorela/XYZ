using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;

	void Start () {
		GetComponent<Rigidbody2D>().useGravity = false;
		GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints.FreezeRotation;

		myTransform = transform;
	}

	void FixedUpdate () {
		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}
