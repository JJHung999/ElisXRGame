using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: https://www.youtube.com/watch?v=LziIlLB2Kt4

public class PanelOpener : MonoBehaviour
{
    public GameObject GenAITextBox;
    public GameObject AvatarBox;

    public void OpenPanel()
    {
        if(GenAITextBox != null)
        {
            bool isActive = GenAITextBox.activeSelf;
            GenAITextBox.SetActive(!isActive);
        }

        if(AvatarBox != null)
        {
            bool isActive = AvatarBox.activeSelf;
            AvatarBox.SetActive(!isActive);
        }
    }
}
