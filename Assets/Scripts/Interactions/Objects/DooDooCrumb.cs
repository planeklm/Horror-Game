using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DooDooCrumb : MonoBehaviour, IInteractable
{
    public bool HasInteracted
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }

    public string GetDescription()
    {
        return "What the actual hell is that? That's the last time I let Jimmy in.";
    }

    public string GetInteractText()
    {
        return "[E] Inspect";
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public bool Interacted()
    {
        throw new System.NotImplementedException();
    }
}
