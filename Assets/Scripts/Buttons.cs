using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Script for Buttons */
/* Mark Crawford, Andrew Mobus */
/* CSC350H - Professor Tang */
/* Final Project */
/* Updated: 05/19/2024 */


public class Buttons : MonoBehaviour
{

    // Game Start
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    //Instructions
    public void GetInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    // Handle restart
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    // Back to Menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
