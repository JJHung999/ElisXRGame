using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: https://www.youtube.com/watch?v=LziIlLB2Kt4

public class GoalsPanel : MonoBehaviour
{
    public GameObject MissionPanel;

    public void OpenPanel3()
    {
        if(MissionPanel != null)
        {
            bool isActive = MissionPanel.activeSelf;
            MissionPanel.SetActive(!isActive);
        }
    }
}
