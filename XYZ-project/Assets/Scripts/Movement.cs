using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float maxSpeed = 0.5f;
	public float moveH = 0;
	public float moveV = 0;





	public void moveRightDown(){
		moveH = 1*maxSpeed;
	}
	public void moveRightUp(){
		moveH = 0*maxSpeed;
	}
	public void moveLeftDown(){
		moveH = -1*maxSpeed;
	}
	public void moveLeftUp(){
		moveH = 0*maxSpeed;
	}
	public void moveUpDown(){
		moveV = 1*maxSpeed;
	}
	public void moveUpUp(){
		moveV = 0*maxSpeed;
	}
	public void moveDownDown(){
		moveV = -1*maxSpeed;
	}
	public void moveDownUp(){
		moveV = 0*maxSpeed;
	}
	void Update(){
		transform.GetComponent<Rigidbody2D> ().AddForce(Vector3.right*moveH);
		transform.GetComponent<Rigidbody2D> ().AddForce(Vector3.up*moveV);


		}
	
}
