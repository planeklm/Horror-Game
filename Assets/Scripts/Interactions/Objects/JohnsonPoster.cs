using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnsonPoster : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "Jimmy dropped the duce. Godamnit.";
    }

    public string GetInteractText()
    {
        return null;
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }
}
