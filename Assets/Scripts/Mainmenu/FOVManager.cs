using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FOV : MonoBehaviour
{
    [SerializeField]
    Slider fovSlider;

    [SerializeField]
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        if (!cam)
            cam = GetComponent<Camera>();

        if (!PlayerPrefs.HasKey("fov"))
        {
            PlayerPrefs.SetFloat("fov", 60);
            Load();
        }
        else
        {
            Load();
        }
    }

    void Update()
    {
        print(Camera.main.fieldOfView);
    }

    // Update is called once per frame
    public void ChangeFOV()
    {
        fovSlider.value = cam.fieldOfView;
        Save();
    }

    private void Load()
    {
        fovSlider.value = PlayerPrefs.GetFloat("fov");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("fov", fovSlider.value);
    }
}
