using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float cameraSpeed;
	public GameObject closestPlanet;
	public float offsetZ = 0;

	void Update() {

		cameraFollowClosestPlanet ();
	
	}

	void cameraFollowClosestPlanet (){

		GameObject[] planets = GameObject.FindGameObjectsWithTag ("Planet");
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		
		float minDist = Mathf.Infinity;
		Vector3 currentPos = player.transform.position;
		GameObject tMin = null;
		
		foreach (GameObject p in planets) {
			
			float dist = Vector3.Distance(p.transform.position, currentPos);
			if(dist < minDist){
				tMin = p;
				minDist = dist;
			}
		}
		
		Vector3 direction =  new Vector3 ( tMin.transform.position.x, tMin.transform.position.y, -10);
		transform.position = Vector3.MoveTowards (transform.position, direction, cameraSpeed);

	}
}
