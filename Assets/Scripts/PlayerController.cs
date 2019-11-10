using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private float speed=25f;
	public float jumpForce;
	private float moveInput;
	private Rigidbody2D rb;
	private Animator ani;
	private AudioSource aud;
	private bool facingRight = true;

	//ground variables
	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	public int extraJumps;
	private Animator animator;
	
	void Start(){
		rb = GetComponent<Rigidbody2D>();
		ani = GetComponent<Animator>();
		aud = GetComponent<AudioSource>();

	}

	void Update(){
		if(isGrounded == true)
		{
			ani.SetBool("Jumping", false);
			extraJumps=2;
		}

		if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
		{
			rb.velocity = Vector2.up * jumpForce;
			extraJumps--;
			ani.SetBool("Jumping", true);
			aud.Play();
		} else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps==0 && isGrounded==true)
		{
			rb.velocity=Vector2.up*jumpForce;
		}
	}

	void FixedUpdate(){
		isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);

		moveInput = Input.GetAxis("Horizontal");
		if (moveInput == 0){
			ani.SetBool("Running", false);
		} else {ani.SetBool("Running", true);}
		
		rb.velocity = new Vector2(moveInput*speed,rb.velocity.y);


		if(facingRight == false && moveInput >0)
		{
			flip();
		}else if (facingRight == true && moveInput < 0)
		{
			flip();
		}
	}

	void flip(){
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *=-1;
		transform.localScale = Scaler;
	}
}
