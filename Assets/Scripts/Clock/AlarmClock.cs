using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour, IInteractable
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public bool alarmClockStatus;

    public bool HasInteracted
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }

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
        audioSource.GetComponent<AudioSource>().clip = audioClip;
        audioSource.Play();
        alarmClockStatus = true;
    }

    void DisabledAlarmClock()
    {
        audioSource.Stop();
        alarmClockStatus = false;
    }

    public void Interact()
    {
        DisabledAlarmClock();
    }
}
