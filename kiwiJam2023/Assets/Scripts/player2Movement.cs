using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private float horizontal;
    private float vertical;
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            movement.x = 0;
            movement.y = 1;
        } else if(Input.GetKey("down")){
            movement.x = 0;
            movement.y = -1;
        } else if(Input.GetKey("left")){
            movement.x = -1;
            movement.y = 0;
        } else if(Input.GetKey("right")){
            movement.x = 1;
            movement.y = 0;
        } else {
            movement.x = 0;
            movement.y = 0;
        }
    }

    // called a set amount of times a second, better for physics
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
