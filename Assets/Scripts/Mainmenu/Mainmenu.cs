using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    private int CurrentScene = 0;
    public GameObject levelLoaderObject;
    public LevelLoader levelLoaderScript;
    public GameObject settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false);
    }

    public void PlayGame()
    {
        levelLoaderScript.LoadNextLevel();
        print("Success: Loading scene " + CurrentScene);
    }

    public void Settings()
    {
        SettingsPanel(true);
        print("Success: Opening settings menu");
    }

    public void CloseSettings()
    {
        SettingsPanel(false);
        print("Success: Closing settings menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Success: The game has been closed.");
    }

    void SettingsPanel(bool State)
    {
        if (State == true)
        {
            settingsPanel.SetActive(true);
        }
        if (State == false)
        {
            settingsPanel.SetActive(false);
        }
    }
}
