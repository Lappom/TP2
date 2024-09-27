using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGestion : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(camera1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(camera2);
        }
    }

    void SwitchCamera(Camera activeCamera)
    {
        camera1.enabled = false;
        camera2.enabled = false;

        activeCamera.enabled = true;
    }
}
