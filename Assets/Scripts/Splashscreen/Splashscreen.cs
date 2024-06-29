using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
    public float waitTime = 6f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSplashscreen());
    }

    IEnumerator WaitForSplashscreen()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(1);
    }
}
