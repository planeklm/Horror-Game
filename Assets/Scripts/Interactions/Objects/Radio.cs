using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, IInteractable
{
    private bool radioToggle;
    public AudioSource audioSource;

    void Awake()
    {
        GetComponent<Radio>().enabled = false;
        print("Done!");
    }

    void Start()
    {
        audioSource.Play();
        radioToggle = true;
    }

    void Update()
    {
        print(radioToggle);
    }

    public string GetDescription()
    {
        return null;
    }

    public string GetInteractText()
    {
        return "[E] Use the radio";
    }

    public void Interact()
    {
        radioToggle = !radioToggle;

        if (radioToggle)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else
            {
                audioSource.Play();
            }
        }
        if (!radioToggle)
        {
            audioSource.Pause();
        }
    }
}
