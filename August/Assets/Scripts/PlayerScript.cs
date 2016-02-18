using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int PlayerSpeed; 
	public int JumpForce;
	private bool isGrounded;
	// Use this for initialization
	void Start () {
		isGrounded = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * PlayerSpeed * Time.deltaTime);

		if(Input.GetKeyDown("space") && isGrounded == true){
			GetComponent<Rigidbody> ().AddForce (Vector3.up * JumpForce);
			isGrounded = false;
	}
}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ground")
		isGrounded = true;
	}
	void OnCollisionExit(Collision collision){
		isGrounded = false;
	}
    public void playerJump()
    {
        if (isGrounded == true) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce);
            isGrounded = false;
        }
    }
}
