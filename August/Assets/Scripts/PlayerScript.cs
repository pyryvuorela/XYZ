using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int PlayerSpeed; 
	public int JumpForce;
	private bool isGrounded;
    private Animator anim;
    private Vector2 playerMove;
    // Use this for initialization
    void Start () {
		isGrounded = false;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);

        anim.SetBool("Jump", isGrounded);

        if (Input.GetKeyDown("space") && isGrounded == true){
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * JumpForce);
			isGrounded = false;
	}
}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Ground")
		isGrounded = true;
	}
	void OnCollisionExit2D(Collision2D collision){
		isGrounded = false;
	}
    public void playerJump()
    {
        if (isGrounded == true) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
            isGrounded = false;
        }
    }
}
