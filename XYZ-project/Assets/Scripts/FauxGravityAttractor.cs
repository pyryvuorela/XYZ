using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {

	public float gravity = -12;
	public float gravityField = 100;
	public float dist = 0;
	private Transform body = null;




	public void Update(){
	GameObject other = GameObject.FindGameObjectWithTag ("Player");
		body = other.transform;
	
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.up;
		dist = Vector3.Distance (transform.position, body.position);


		if (gravityField > Vector3.Distance(transform.position,body.position)) {
			body.GetComponent<Rigidbody2D> ().AddForce (gravityUp * gravity);

			Quaternion targetRotation = Quaternion.FromToRotation (localUp, gravityUp) * body.rotation;
			body.rotation = Quaternion.Slerp (body.rotation, targetRotation, 50f * Time.deltaTime);
		}
	}
}
