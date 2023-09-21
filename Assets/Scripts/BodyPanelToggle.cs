using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: https://www.youtube.com/watch?v=LziIlLB2Kt4

public class BodyPanel : MonoBehaviour
{
    public GameObject RiggedBodyViewer;

    public void OpenPanel2()
    {
        if(RiggedBodyViewer != null)
        {
            bool isActive = RiggedBodyViewer.activeSelf;
            RiggedBodyViewer.SetActive(!isActive);
        }
    }
}
