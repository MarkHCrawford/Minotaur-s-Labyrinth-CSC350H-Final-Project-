using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Script for Victory */
/* Mark Crawford, Andrew Mobus */
/* CSC350H - Professor Tang */
/* Final Project */
/* Updated: 05/19/2024 */


public class WonGame : MonoBehaviour
{
    // Game Over Screen
    public GameObject Victory;
    

    // Start is called before the first frame update
    void Start()
    {
        // start time
        Time.timeScale = 1f;

        // hide end screen
        Victory.SetActive(false);

    }


    // Collision
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // if player collides with wall
        if (collision.tag == "Player")
        {

            // pause
            Time.timeScale = 0f;

            // Activate game over screen
            Victory.SetActive(true);

        }
    }
}
