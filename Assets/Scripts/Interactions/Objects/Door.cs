using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public LevelLoader levelLoaderScript;

    public string GetDescription()
    {
        return null;
    }

    public string GetInteractText()
    {
        return "[E] Open the door";
    }

    public void Interact()
    {
        FindObjectOfType<AudioManager>().Play("OpeningDoor");
        levelLoaderScript.LoadNextLevel();
    }
}
