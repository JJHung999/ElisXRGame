using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameraDisplay : MonoBehaviour
{
    //Cameras
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;

    //Type B Button
    public Button TypeB, OutfitBtn1, OutfitBtn2, OutfitBtn3, OutfitBtn4, OutfitBtn5;

    //Type A Button
    public Button TypeA, OutfitBtn6;

    public void Start()
    {
        //Type B
        TypeB.onClick.AddListener(() => ButtonClicked(0));
        OutfitBtn1.onClick.AddListener(() => ButtonClicked(1));
        OutfitBtn2.onClick.AddListener(() => ButtonClicked(2));
        OutfitBtn3.onClick.AddListener(() => ButtonClicked(3));
        OutfitBtn4.onClick.AddListener(() => ButtonClicked(4));
        OutfitBtn5.onClick.AddListener(() => ButtonClicked(5));

        //Type A
        TypeA.onClick.AddListener(() => ButtonClicked(6));
        OutfitBtn6.onClick.AddListener(() => ButtonClicked(7));
    }

    public void ButtonClicked(int buttonNo)
    {
        if(buttonNo != 0)
        {
            bool isActive = camera1.activeSelf;
            camera1.SetActive(!isActive);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
        }
        if(buttonNo != 1)
        {
            bool isActive = camera1.activeSelf;
            camera1.SetActive(!isActive);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
        }
        if(buttonNo != 2)
        {
            bool isActive = camera2.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(!isActive);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
        }
        if(buttonNo != 3)
        {
            bool isActive = camera3.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(!isActive);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
        }
        if(buttonNo != 4)
        {
            bool isActive = camera4.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(!isActive);
            camera5.SetActive(false);
            camera6.SetActive(false);
        }
        if(buttonNo != 5)
        {
            bool isActive = camera5.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(!isActive);
            camera6.SetActive(false);
        }
        if(buttonNo != 6)
        {
            bool isActive = camera6.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(!isActive);
        }
        if(buttonNo != 7)
        {
            bool isActive = camera6.activeSelf;
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(!isActive);
        }
    }
    void Awake ()
    {
        DontDestroyOnLoad (this.gameObject);
    }
}
