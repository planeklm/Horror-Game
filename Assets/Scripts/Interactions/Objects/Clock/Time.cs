using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public TextMeshPro clockText;

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        string timeString = currentTime.ToString("hh:mm");
        clockText.text = timeString;
    }
}
