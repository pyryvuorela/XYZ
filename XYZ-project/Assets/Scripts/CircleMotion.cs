using UnityEngine;
using System.Collections;

public class CircleMotion : MonoBehaviour {
	public float gravityField = 0;
	public float gravityCounter = 0;
	public float angle = 0;
	public float radian = 0;
	public float timeCounter = 0;
	public Vector3 lastDir;

	void Start (){


	}

	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		PlayerMovement playerMovement = player.GetComponent<PlayerMovement> ();
		gravityCounter = playerMovement.gravityFieldCounter;

		if (gravityField >= Vector2.Distance (player.transform.position, transform.position) && gravityCounter <= 0 ) {
			gravityCounter = 0;
			Circle ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			gravityCounter = 1;
		}
		if (gravityField < Vector2.Distance (player.transform.position, transform.position) || gravityCounter > 0) {
			player.transform.position += lastDir;
			Angle ();
		}
		if (gravityCounter > 0) {
			gravityCounter -= Time.deltaTime;
			}
	}

	void Circle ()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		timeCounter += Time.deltaTime;
		
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
