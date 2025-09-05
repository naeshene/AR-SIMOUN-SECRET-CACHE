using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
   
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Main Menu
    }

    public void GoToLevels()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Levels
    }

    public void GoToAlbum()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Album
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Menu

    public void GoToTutorial()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Tutorial
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Settings
    }

    public void GoToAbout()
    {
        SceneManager.LoadScene("MainMenu"); // Go to About
    }

    public void GoToExit()
    {
        SceneManager.LoadScene("MainMenu"); // Go to Exit
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting..."); // Works only on device, not in editor
    }

}
