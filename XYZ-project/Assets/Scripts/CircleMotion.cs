using UnityEngine;
using System.Collections;

public class CircleMotion : MonoBehaviour {
	public float gravityField = 0;
	public float gravityEffectField = 0;
	public float rotationSpeed = 1;
	Vector3 lastDir;
	float angle = 0;
	float radian = 0;
	float timeCounter = 0;
	float gravityCounter = 0;
	float rotationAngle = 0;
	float temporaryRotationAngle = 0;
	bool isInGravityField = false;


	void Update () {

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		PlayerMovement playerMovement = player.GetComponent<PlayerMovement> ();
		gravityCounter = playerMovement.gravityFieldCounter;

		rotationAngle = Vector2.Angle ((player.transform.position - transform.position), Vector2.up);

		if (Vector2.Distance (player.transform.position, transform.position) < gravityField * 2 && Vector2.Distance (player.transform.position, transform.position) > gravityField * 1.5) {
			temporaryRotationAngle = rotationAngle;
		}
		if (gravityField >= Vector2.Distance (player.transform.position, transform.position) && gravityCounter <= 0 ) {
			gravityCounter = 0;
			Circle ();
		}
		if (gravityField < Vector2.Distance (player.transform.position, transform.position) || gravityCounter > 0) {
			player.transform.Translate(lastDir);
			Angle ();
		}
		if (gravityCounter > 0) {
			gravityCounter -= Time.deltaTime;
			isInGravityField = false;
			rotationSpeed = 1;
			}
		if (gravityEffectField > Vector2.Distance (player.transform.position, transform.position) && gravityField < Vector2.Distance (player.transform.position, transform.position) && gravityCounter <= 0 ) {
			player.transform.position = Vector2.MoveTowards(player.transform.position, transform.position, gravityEffectField*Time.deltaTime);
		}
	}

	void Circle ()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (isInGravityField == false) {
			if (temporaryRotationAngle < rotationAngle && player.transform.position.x < transform.position.x) {
				rotationSpeed *= 1;
			} 
			if (temporaryRotationAngle > rotationAngle && player.transform.position.x < transform.position.x) {
				rotationSpeed *= -1;
			} 
			if (temporaryRotationAngle > rotationAngle && player.transform.position.x > transform.position.x) {
				rotationSpeed *= 1;
			} 
			if (temporaryRotationAngle < rotationAngle && player.transform.position.x > transform.position.x) {
				rotationSpeed *= -1;
			} 
			isInGravityField= true;
		}

		timeCounter += Time.deltaTime * rotationSpeed;
		float x = Mathf.Cos (timeCounter) * (gravityField - 2);
		float y = Mathf.Sin (timeCounter)*(gravityField-2);
		Vector3 newDir =  player.transform.position;
		player.transform.position = new Vector2 (x + transform.position.x, y + transform.position.y);
		lastDir = (player.transform.position - newDir);

	}

	void Angle ()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		Vector2 targetDir = player.transform.position - transform.position;
		Vector2 rigth = transform.right;
		angle = Vector2.Angle (targetDir,rigth);
		radian = angle / (180 / Mathf.PI);

		if (player.transform.position.y > transform.position.y) {
			timeCounter = radian;

		}
		if (player.transform.position.y < transform.position.y) {
			timeCounter = Mathf.PI + (Mathf.PI- radian);
		}
	}
}