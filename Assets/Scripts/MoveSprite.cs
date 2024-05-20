using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Script to move Player Minotaur */
/* Mark Crawford, Andrew Mobus */
/* CSC350H - Professor Tang */
/* Final Project */
/* Updated: 05/19/2024 */

public class MoveSprite : MonoBehaviour
{
    // Speed of Minotaur
    public float speed;

    // Attach RigidBody
    public Rigidbody2D rb2d;

    // Vector for player direction
    private Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }


    // Get player input
    void GetInput()
    {
        float xDir = Input.GetAxisRaw("Horizontal");
        float yDir = Input.GetAxisRaw("Vertical");

        direction = new Vector2(xDir, yDir).normalized;
    }

    void MovePlayer()
    {
        rb2d.velocity = new Vector2(direction.x * speed, direction.y * speed);
        
        // change animation to walking
        if (direction.x != 0 || direction.y != 0)
        {
            // change animation to walking
            GetComponent<Animator>().SetBool("isWalking", true);
        }
        else
        {
            // change animation to idle
            GetComponent<Animator>().SetBool("isWalking", false);
        }
    }


    // Death animation on collision
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // if player collides with wall
        if (collision.tag == "Boundary")
        {
            // change animation to death
            GetComponent<Animator>().SetBool("isDead", true);
        }
    }
}
