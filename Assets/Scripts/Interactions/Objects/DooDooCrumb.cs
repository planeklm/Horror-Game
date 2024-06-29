using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DooDooCrumb : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "What the actual hell is that? That's the last time I let Jimmy in.";
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
