using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "I should probaly move these.";
    }

    public string GetInteractText()
    {
        return "";
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }
}
