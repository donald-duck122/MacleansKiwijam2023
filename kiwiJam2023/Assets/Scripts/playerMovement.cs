using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private float horizontal;
    private float vertical;
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("w")){
        //     vertical = 1;
        // } else if(Input.GetKeyDown("a")){
        //     horizontal = -1;
        // } else if(Input.GetKeyDown("s")){
        //     vertical = -1;
        // } else if(Input.GetKeyDown("d")){
        //     horizontal = 1;
        // }

        if(Input.GetAxisRaw("Horizontal") != 0){
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = 0;
        } else if(Input.GetAxisRaw("Vertical") != 0){
            movement.x = 0;
            movement.y = Input.GetAxisRaw("Vertical");
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
