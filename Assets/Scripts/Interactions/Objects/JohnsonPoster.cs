using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnsonPoster : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "Jimmy dropped the duce again. Goddamnit.";
    }

    public string GetInteractText()
    {
        return null;
    }

    public void Interact()
    {
        return;
    }
}
