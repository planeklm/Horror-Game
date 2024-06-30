using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnsonPoster : MonoBehaviour, IInteractable
{
    public GameObject poster;

    public string GetDescription()
    {
        return "DID JOHNATHAN SNEAK IN AGAIN WHEN I WAS SLEEPING???";
    }

    public string GetInteractText()
    {
        return "[E] Rip the poster down";
    }

    public void Interact()
    {
        DestroyPoster();
    }

    private void DestroyPoster()
    {
        FindObjectOfType<AudioManager>().Play("RippingPaper");
        GameManager.instance.PostersRipped();
        Destroy(poster);
    }
}
