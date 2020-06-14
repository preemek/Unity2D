using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public float shootForce = 20f;
    public GameObject bullet;
    public Transform firepoint;
   

    public void Start()
    {
       
    }
    private void FixedUpdate()
    {


        if (Input.GetKey("space"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
        bullet.GetComponent<RigidBody2d>().velocity = new UnityEngine.Vector2(shootForce, 0);

    }

}
