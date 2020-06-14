using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5;
    public float jumpHeight = 5;
    public Animator animator;

    private Rigidbody2D rb;
    public LayerMask whatIsGround;
    private new Collider2D collider;
    private bool onGround = true;


    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        onGround = collider.IsTouchingLayers(whatIsGround);

    }

    private void FixedUpdate()
    {
       

        if (Input.GetKey("a"))
        {
            if (Input.GetKey("w") && onGround == true) { rb.velocity = new UnityEngine.Vector2(rb.velocity.x, jumpHeight); }

            rb.velocity = new UnityEngine.Vector2(-speed, rb.velocity.y);
            animator.SetInteger("ConditionHorizontal", -2);
          
        }

        else if (Input.GetKey("d"))
        {
            if (Input.GetKey("w") && onGround == true) { rb.velocity = new UnityEngine.Vector2(rb.velocity.x, jumpHeight); }
            rb.velocity = new UnityEngine.Vector2(speed, rb.velocity.y);
            animator.SetInteger("ConditionHorizontal", 2);
           
        }

        else if (Input.GetKey("w") && onGround == true)
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, jumpHeight);
           
        }
        
        else
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, rb.velocity.y);
            animator.SetInteger("ConditionHorizontal", 100);


        }


    }
}
