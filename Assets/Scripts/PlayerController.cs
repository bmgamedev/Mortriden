using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    public float jump;

    private bool isGrounded;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private SpriteRenderer spriterenderer;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();

        spriterenderer = GetComponent<SpriteRenderer>();

        //isGrounded = true;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);

        if (moveHorizontal < 0){
            spriterenderer.flipX = true;
        } else if (moveHorizontal > 0) {
            spriterenderer.flipX = false;
        }


        if (Input.GetButton("Jump"))
        {
            //print("I should be jumping");
            if (isGrounded)
            {
                //isGrounded = false;
                rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            } else
            {
                //print("but i can't because apparently i already am... pixel boyz cant jump");
            }

            //print("I've now finished jumping");
            //isGrounded = true;
        }

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (isGrounded)
            {
                isGrounded = false;
            }
        }
        
    }

}