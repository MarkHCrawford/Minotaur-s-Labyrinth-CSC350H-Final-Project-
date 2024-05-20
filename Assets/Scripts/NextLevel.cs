using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Script to transition levels */
/* Mark Crawford, Andrew Mobus */
/* CSC350H - Professor Tang */
/* Final Project */
/* Updated: 05/19/2024 */


public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Handle level transition 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // if player collides with wall
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
