using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;

	void Start () {
		myTransform = transform;
	}

	void FixedUpdate () {
		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}
