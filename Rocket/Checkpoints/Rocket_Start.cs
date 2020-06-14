using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Rocket_Start : MonoBehaviour
{
    public Camera cam;
    private GameObject rocket;
    private Rigidbody2D rb;
    private GameObject player;
    private SpriteRenderer sprite;



    // Start is called before the first frame update
    void Start()
    {
        rocket = GameObject.Find("Rocket");
        player = GameObject.Find("Player");
        sprite = player.GetComponent<SpriteRenderer>();
        rb = rocket.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag is "Player")
        {
            sprite.enabled = false;
            player.GetComponentInChildren<Camera>().enabled = false;
            cam.enabled = true;
            //rocket.GetComponentInChildren<Camera>().enabled = true;
            rocket.GetComponent<Rocket_Controll>().enabled = true;
            player.GetComponent<Player_Movement>().enabled = false;
        
            
        }
    }
}
