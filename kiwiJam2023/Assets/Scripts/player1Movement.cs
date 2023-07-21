using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Movement : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    private float dirX;

    private BoxCollider2D coll;

    private Rigidbody2D rb;

    [SerializeField] private LayerMask jumpableGround;


    public void Start(){

        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();

    }


    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
    
        if(Input.GetButtonDown("Jump") && IsGrounded()){
           rb.velocity = new Vector2(rb.velocity.x, vertical*1.5f);

        } 

        if(Input.GetKeyDown("d") && !IsGrounded()){
            rb.velocity = new Vector2(dirX * horizontal/1.5f, rb.velocity.y);
        }

        if(Input.GetKeyDown("a") && !IsGrounded()){
            rb.velocity = new Vector2(horizontal/1.5f * dirX, rb.velocity.y);
        }

        if(Input.GetKeyDown("d") && IsGrounded()){
           rb.velocity = new Vector2(horizontal, vertical/1.2f);
        } 

        if(Input.GetKeyDown("a") && IsGrounded()){
           rb.velocity = new Vector2(-horizontal, vertical/1.2f);
        } 

      
    }

    private bool IsGrounded(){
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    // called a set amount of times a second, better for physics
    void FixedUpdate() 
    {
    }
}
