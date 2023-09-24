using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.UI;

//source: https://www.youtube.com/watch?v=ZVrfNivw7PY

public class CameraScriptCinemachine : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cam1;
    [SerializeField] CinemachineVirtualCamera cam2;
    [SerializeField] CinemachineVirtualCamera cam3;
    [SerializeField] CinemachineVirtualCamera cam4;
    [SerializeField] CinemachineVirtualCamera cam5;
    [SerializeField] CinemachineVirtualCamera cam6;

    private void OnEnable()
    {
        CameraSwitcher.Register(cam1);
        CameraSwitcher.Register(cam2);
        CameraSwitcher.Register(cam3);
        CameraSwitcher.Register(cam4);
        CameraSwitcher.Register(cam5);
        CameraSwitcher.Register(cam6);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(cam1);
        CameraSwitcher.Unregister(cam2);
        CameraSwitcher.Unregister(cam3);
        CameraSwitcher.Unregister(cam4);
        CameraSwitcher.Unregister(cam5);
        CameraSwitcher.Unregister(cam6);
    }

    //if button is pressed. Switch the camera

    public void OpenCam1()
    {
        if(CameraSwitcher.IsActiveCamera(cam1))
        {
            CameraSwitcher.SwitchCamera(cam1);
        }
    }
    public void OpenCam2()
    {
        if(CameraSwitcher.IsActiveCamera(cam2))
        {
            CameraSwitcher.SwitchCamera(cam2);
        }
    }
    public void OpenCam3()
    {
        if(CameraSwitcher.IsActiveCamera(cam3))
        {
            CameraSwitcher.SwitchCamera(cam3);
        }
    }
    public void OpenCam4()
    {
        if(CameraSwitcher.IsActiveCamera(cam4))
        {
            CameraSwitcher.SwitchCamera(cam4);
        }
    }
    public void OpenCam5()
    {
        if(CameraSwitcher.IsActiveCamera(cam5))
        {
            CameraSwitcher.SwitchCamera(cam5);
        }
    }
    public void OpenCam6()
    {
        if(CameraSwitcher.IsActiveCamera(cam6))
        {
            CameraSwitcher.SwitchCamera(cam6);
        }
    }

}
