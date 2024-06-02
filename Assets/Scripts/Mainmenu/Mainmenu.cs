using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    private int CurrentScene = 0;

    public void PlayGame()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex + 2;
        SceneManager.LoadScene(CurrentScene);
        print("Success: Loading scene " + CurrentScene);
    }

    public void Settings()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(CurrentScene);
        print("Success: Loading scene " + CurrentScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Success: The game has been closed.");
    }
}
