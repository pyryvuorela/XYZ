using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float maxSpeed = 0.5f;
	public float moveH = 0;
	public float moveV = 0;



	public void moveRightDown(){
		moveH = 1;
	}
	public void moveRightUp(){
		moveH = 0;
	}
	public void moveLeftDown(){
		moveH = -1;
	}
	public void moveLeftUp(){
		moveH = 0;
	}
	public void moveUpDown(){
		moveV = 1;
	}
	public void moveUpUp(){
		moveV = 0;
	}
	public void moveDownDown(){
		moveV = -1;
	}
	public void moveDownUp(){
		moveV = 0;
	}
	void Update(){
		transform.Translate(Vector3.right*moveH);
		transform.Translate(Vector3.up*moveV);
		}
}
