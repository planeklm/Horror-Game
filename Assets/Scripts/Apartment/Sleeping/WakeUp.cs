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

    public AlarmClock alarmClock;

    public PlayerInteractions playerInteractions;
    public PlayerInteractions playerInteractionsSleeping;

    public GameObject player;
    public Movement movement; // this will be the container of the script

    private bool canGetUp;

    void Start()
    {
        sleepingCamera.enabled = true;
        playerCamera.enabled = false;

        sleepingCamAudio.enabled = true;
        playerCamAudio.enabled = false;

        sleepingUI.SetActive(true);

        FindObjectOfType<AudioManager>().Play("Snoring");
        StatusPlayer(false, false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !alarmClock.alarmClockStatus)
        {
            if (sleepingCamera.enabled)
            {
                GetUpFromBed();
            }
        }
    }

    void GetUpFromBed()
    {
        GameManager.instance.UpdateGameState(GameState.GotUpFrombed);

        SwitchCamera();
        StopSleepUI();
        FindObjectOfType<AudioManager>().Stop("Snoring");
        FindObjectOfType<AudioManager>().Play("Sheetsrussling");
        StatusPlayer(true, true);
    }

    void StopSleepUI()
    {
        sleepingUI.SetActive(false);
    }

    void StatusPlayer(bool look, bool move)
    {
        movement = player.GetComponent<Movement>();

        movement.canLook = look;
        movement.canMove = move;
    }

    //! This should be changed, it's really bad. Like really bad. D:

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
