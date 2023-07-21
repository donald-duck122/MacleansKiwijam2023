using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private float horizontal;
    private float vertical;
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            movement.x = 0;
            movement.y = 1;
        } else if(Input.GetKey("s")){
            movement.x = 0;
            movement.y = -1;
        } else if(Input.GetKey("a")){
            movement.x = -1;
            movement.y = 0;
        } else if(Input.GetKey("d")){
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
