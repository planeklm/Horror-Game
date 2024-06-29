using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public Camera sleepingCamera;
    public Camera playerCamera;

    public AudioListener sleepingCamAudio;
    public AudioListener playerCamAudio;

    public GameObject sleepingUI;
    public TextMeshProUGUI sleepingUIText;

    public AudioSource sound;
    public AudioClip snoringSFX;
    public AudioClip yawnSFX;

    public AlarmClock alarmClock;

    public PlayerInteractions playerInteractions;
    public PlayerInteractions playerInteractionsSleeping;

    public GameObject player;
    public Movement movement; // this will be the container of the script

    void Start()
    {
        sleepingCamera.enabled = true;
        playerCamera.enabled = false;

        sleepingCamAudio.enabled = true;
        playerCamAudio.enabled = false;

        sound.GetComponent<AudioSource>().clip = snoringSFX;
        sound.Play();

        StatusPlayer(false, false);
    }

    void Update()
    {
        //if we click space we will get up from the bed, destroying the UI, changing camera, changing player state and destroys the sound.
        if (Input.GetKey(KeyCode.Space) && alarmClock.alarmClockStatus == false)
        {
            if (sleepingCamera.enabled == true)
            {
                GetUpFromBed();
            }
        }

        if (alarmClock.alarmClockStatus == false)
        {
            sleepingUIText.text = "(press SPACE to get up)";
        }
    }

    void GetUpFromBed()
    {
        GameManager.Instance.UpdateGameState(GameState.GotUpFrombed);

        SwitchCamera();
        BreakSleepUI();
        BreakSleepSound();
        StatusPlayer(true, true);

        Destroy(sleepingUI);
    }

    void BreakSleepSound()
    {
        sound.Stop();
        sound.GetComponent<AudioSource>().clip = yawnSFX;
        sound.loop = false;
        sound.Play();
    }

    void BreakSleepUI()
    {
        sleepingUI.SetActive(false);
    }

    void StatusPlayer(bool look, bool move)
    {
        movement = player.GetComponent<Movement>();

        movement.canLook = look;
        movement.canMove = move;
    }

    void SwitchCamera()
    {
        sleepingCamera.enabled = !sleepingCamera.enabled;
        playerCamera.enabled = !playerCamera.enabled;

        SwitchAudio();
        SwitchInteractions();
    }

    void SwitchAudio()
    {
        sleepingCamAudio.enabled = !sleepingCamAudio.enabled;
        playerCamAudio.enabled = !playerCamAudio.enabled;
    }

    void SwitchInteractions()
    {
        playerInteractionsSleeping.enabled = !playerInteractionsSleeping.enabled;
        playerInteractions.enabled = !playerInteractions.enabled;
    }
}
