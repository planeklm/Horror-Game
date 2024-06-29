using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour, IInteractable
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AlarmClock alarmClock;

    [HideInInspector]
    public bool alarmClockStatus;

    void Start()
    {
        EnabledAlarmClock();
    }

    public string GetDescription()
    {
        return "";
    }

    public string GetInteractText()
    {
        return "[E] Stop the alarm.";
    }

    void EnabledAlarmClock()
    {
        FindObjectOfType<AudioManager>().PlayAudio(audioSource, "AlarmClock");
        alarmClockStatus = true;
    }

    void DisabledAlarmClock()
    {
        FindObjectOfType<AudioManager>().StopAudio(audioSource, "AlarmClock");
        alarmClockStatus = false;
        Destroy(alarmClock);
    }

    public void Interact()
    {
        DisabledAlarmClock();
    }
}
