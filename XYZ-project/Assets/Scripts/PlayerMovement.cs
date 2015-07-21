using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float gravityFieldCounter = 0;

	public void GravityTouch(int counter){
		gravityFieldCounter = counter;
	}
	void Update(){
		if(gravityFieldCounter > 0){
			gravityFieldCounter -= Time.deltaTime;
		}
	}
}
