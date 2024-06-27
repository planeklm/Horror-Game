using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public Camera sleepingCamera;
    public Camera playerCamera;

    public AudioListener sleepingCamAudio;
    public AudioListener playerCamAudio;

    public GameObject sleepingUI;

    public AudioSource sound;
    public AudioClip snoringSFX;
    public AudioClip yawnSFX;

    public bool alarmClockStatus;

    public GameObject player;
    public Movement movement; // this will be the container of the script

    void Start()
    {
        GameManager.Instance.UpdateGameState(GameState.Sleeping);

        sleepingCamera.enabled = true;
        playerCamera.enabled = false;

        sleepingCamAudio.enabled = true;
        playerCamAudio.enabled = false;

        alarmClockStatus = true;

        sound.GetComponent<AudioSource>().clip = snoringSFX;
        sound.Play();

        StatusPlayer(false, false);
    }

    void Update()
    {
        //if we click space we will get up from the bed, destroying the UI, changing camera, changing player state and destroys the sound.
        if (Input.GetKey(KeyCode.Space))
        {
            if (sleepingCamera.enabled == true)
            {
                GetUpFromBed();
            }
        }
    }

    void GetUpFromBed()
    {
        GameManager.Instance.UpdateGameState(GameState.WokenUp);

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
    }

    void SwitchAudio()
    {
        sleepingCamAudio.enabled = !sleepingCamAudio.enabled;
        playerCamAudio.enabled = !playerCamAudio.enabled;
    }
}
