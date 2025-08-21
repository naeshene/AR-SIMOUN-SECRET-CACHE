using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GotoAlbum() // MainMenu > Album
    {
        SceneManager.LoadScene("Album");
    }

    public void GotoLevels() // MainMenu > Levels
    {
        SceneManager.LoadScene("Levels");
    }

}
