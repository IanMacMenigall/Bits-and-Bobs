using UnityEngine;
using System.Collections;

public class PizzaCutterMovement : MonoBehaviour {

    [HideInInspector]
    public float facing = -1;
    [HideInInspector]
    public bool jump = false;

    public float jumpForce = 500f;
    public Transform groundCheck;

    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (grounded)
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {

        if (jump)
        {
            anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(-5f, jumpForce));
            jump = false;
        }

    }

}
