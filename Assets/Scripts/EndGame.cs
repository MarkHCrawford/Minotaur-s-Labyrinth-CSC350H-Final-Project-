using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Script for Ending Game */
/* Mark Crawford, Andrew Mobus */
/* CSC350H - Professor Tang */
/* Final Project */
/* Updated: 05/19/2024 */


public class EndGame : MonoBehaviour
{
    // Game Over Screen
    public GameObject gameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
        // start time
        Time.timeScale = 1f;

        // hide end screen
        gameOverScreen.SetActive(false);
        
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
            gameOverScreen.SetActive(true);
  
        }
    }
}
