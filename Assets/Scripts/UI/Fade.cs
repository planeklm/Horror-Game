using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup myUIGroup;

    [SerializeField]
    private bool fadeIn = false;

    [SerializeField]
    private bool fadeOut = false;

    public void FadeIn()
    {
        fadeIn = true;
        myUIGroup.alpha = 1;
    }

    public void FadeOut()
    {
        fadeOut = true;
        myUIGroup.alpha = 0;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut)
        {
            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha == 1)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
