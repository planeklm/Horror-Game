using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimmyDidIt : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "There is no way John thinks Jimmy did it, right?";
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
