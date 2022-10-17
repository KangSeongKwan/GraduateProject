using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;

    void Start()
    {
        mainCameraOn();
    }

    public void mainCameraOn()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;
    }
    
    public void subCameraOn()
    {
        mainCamera.enabled = false;
        subCamera.enabled = true;
    }
}
