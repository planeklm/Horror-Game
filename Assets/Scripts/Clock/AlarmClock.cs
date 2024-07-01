using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlarmClock : MonoBehaviour, IInteractable
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public TextMeshProUGUI sleepingUIText;

    [HideInInspector]
    public bool alarmClockStatus;

    void Start()
    {
        EnabledAlarmClock();
    }

    public string GetDescription()
    {
        return null;
    }

    public string GetInteractText()
    {
        return "[E] Stop the alarm";
    }

    void EnabledAlarmClock()
    {
        FindObjectOfType<AudioManager>().PlayAudio(audioSource, "AlarmClock");
        alarmClockStatus = true;
    }

    void DisabledAlarmClock()
    {
        FindObjectOfType<AudioManager>().StopAudio(audioSource, "AlarmClock");
        FindObjectOfType<AudioManager>().Play("Beep");

        alarmClockStatus = false;
        sleepingUIText.text = "(press SPACE to get up)";
        GetComponent<AlarmClock>().enabled = false;
    }

    public void Interact()
    {
        DisabledAlarmClock();
    }
}
