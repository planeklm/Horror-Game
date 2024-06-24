using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public Camera sleepingCamera;
    public Camera playerCamera;
    public GameObject sleepPanel;

    public AudioSource sound;
    public AudioClip snoringSFX;
    public AudioClip yawnSFX;

    public GameObject Player;
    public Movement movement; // this will be the container of the script

    void Start()
    {
        sleepingCamera.enabled = true;
        playerCamera.enabled = false;

        sound.GetComponent<AudioSource>().clip = snoringSFX;
        sound.Play();

        movement = Player.GetComponent<Movement>();
        movement.canLook = false;
        movement.canMove = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (sleepingCamera.enabled == true)
            {
                SwitchCamera();
                BreakSleepUI();

                sound.Stop();

                sound.GetComponent<AudioSource>().clip = yawnSFX;
                sound.loop = false;
                sound.Play();

                movement.canLook = true;
                movement.canMove = true;
            }
        }
    }

    void SwitchCamera()
    {
        sleepingCamera.enabled = !sleepingCamera.enabled;
        playerCamera.enabled = !playerCamera.enabled;
    }

    void BreakSleepUI()
    {
        sleepPanel.SetActive(false);
    }
}
