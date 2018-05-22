using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour {
	private float speed = 20f;
	private Rigidbody2D rb;
	public Animator anim;
	private bool facingRight;

	void Start(){
		facingRight = false;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
		anim.SetFloat ("speed", 1f);
	}

	void HandleMovement(float horizontal){
		
	//	rb.MovePosition (rb.position +  Vector2.right * horizontal * speed * Time.deltaTime);
		rb.velocity = new Vector2(horizontal*speed,rb.position.y);
		anim.SetFloat("speed",Mathf.Abs(horizontal));
		//for tuchpad
		// if (Input.touchCount > 0) 
		//{
			
		//}

	
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			anim.Play ("Jump");
		}
	}

	private void Flip(float horizontal){
		if (horizontal < 0 &&  facingRight || horizontal > 0 && !facingRight) {
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}

		void FixedUpdate(){
			
			float horizontal = Input.GetAxis ("Horizontal");
			HandleMovement(horizontal);
			Flip(horizontal);
			
	
	}


}
