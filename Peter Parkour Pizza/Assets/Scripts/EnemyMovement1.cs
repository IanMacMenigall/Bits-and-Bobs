using UnityEngine;
using System.Collections;
using System.Collections.Specialized;

public class EnemyMovement1 : MonoBehaviour {
	[HideInInspector]
	public float facing = -1;
	[HideInInspector]
	public bool jump = false;

	public float moveForce = 200f;
	public float maxSpeed = 2f;
	public float jumpForce = 500f;
	public Transform groundCheck;
	public Transform wallCheck;

	private bool grounded = false;
	private bool wall;
    private bool friend;
	private Animator anim;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (GetComponent<Renderer>().isVisible)
        {
            grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            wall = Physics2D.Linecast(transform.position, wallCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            friend = Physics2D.Linecast(wallCheck.position, wallCheck.position, 1 << LayerMask.NameToLayer("Enemy"));

            if (grounded)
            {
                jump = true;
            }

            if (wall || friend)
            {
                Flip();
            }
        }
	}

	void FixedUpdate()
	{
        if(GetComponent<Renderer>().isVisible)
        {
            anim.SetFloat("Speed", Mathf.Abs(facing));

            if (facing * rb2d.velocity.x < maxSpeed)
                rb2d.AddForce(Vector2.right * facing * moveForce);
            if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
                rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

            if (jump)
            {
                anim.SetTrigger("Jump");
                rb2d.AddForce(new Vector2(0f, jumpForce));
                jump = false;
            }
        }

	}

	void Flip()
	{
		facing = -facing;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
