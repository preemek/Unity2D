using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rocket_Controll : MonoBehaviour
{
    public float speed = 5;
    public float speed_of_rotate = 2;
   
    private Rigidbody2D rb;
    private Transform trans;
    public LayerMask whatIsGround;
    private new Collider2D collider;
    private bool onGround;
    private double rocket_angle;
    private double speed_x;
    private double speed_y;
    //private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        trans = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        onGround = collider.IsTouchingLayers(whatIsGround);
        //cam = GetComponentInChildren<Camera>();


    }

    private void FixedUpdate()
    {
  
        if (Input.GetKey("a") && onGround == false)
        {
            transform.Rotate(0, 0, speed_of_rotate);
            //cam.transform.eulerAngles = new Vector3(0, 0, 0);

            rocket_angle = (System.Math.Abs(rb.rotation) * (System.Math.PI)) / 180;

            speed_x = System.Math.Sin(rocket_angle) * speed;
            speed_y = System.Math.Cos(rocket_angle) * speed;
            
            if (rb.rotation > 0) { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
            else { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }
           



        }

        if (Input.GetKey("d") && onGround == false)
        {
            
            transform.Rotate(0, 0, -speed_of_rotate);
            //cam.transform.eulerAngles = new Vector3(0, 0, 0);

            rocket_angle = (System.Math.Abs(rb.rotation) * (System.Math.PI)) / 180;

            speed_x = System.Math.Sin(rocket_angle) * speed;
            speed_y = System.Math.Cos(rocket_angle) * speed;

            if (rb.rotation < 0) { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }
            else { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
            



        }
        if (Input.GetKey("w"))
        {
            if (onGround) 
            { 
                rb.velocity = new UnityEngine.Vector2(0, speed);
            }
            else 
            {
                speed = speed + 1;

                rocket_angle = (System.Math.Abs(rb.rotation) * (System.Math.PI)) / 180;

                speed_x = System.Math.Sin(rocket_angle) * speed;
                speed_y = System.Math.Cos(rocket_angle) * speed;

                if (rb.rotation > 0) { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
                else { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }
                if (rb.rotation < 0) { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }
                else { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
            }         
        }

        if (Input.GetKey("s") && onGround == false)
        {
            if(speed >= 1) 
            { 
                speed = speed - 1;

                rocket_angle = (System.Math.Abs(rb.rotation) * (System.Math.PI)) / 180;

                speed_x = System.Math.Sin(rocket_angle) * speed;
                speed_y = System.Math.Cos(rocket_angle) * speed;

                if (rb.rotation > 0) { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
                else { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }

                if (rb.rotation < 0) { rb.velocity = new UnityEngine.Vector2((float)speed_x, (float)speed_y); }
                else { rb.velocity = new UnityEngine.Vector2((float)-speed_x, (float)speed_y); }
            }        
        }









    }
}