using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    private int CurrentScene = 0;

    public void GoBack()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(CurrentScene);
        print("Success: Loading scene " + CurrentScene);
    }
}
