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
        SceneManager.LoadScene("Levels"); // Go to Levels
    }

    public void GoToAlbum()
    {
        SceneManager.LoadScene("Album"); // Go to Album
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu"); // Go to Menu
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial"); // Go to Tutorial
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings"); // Go to Settings
    }

    public void GoToAbout()
    {
        SceneManager.LoadScene("About"); // Go to About
    }

}
