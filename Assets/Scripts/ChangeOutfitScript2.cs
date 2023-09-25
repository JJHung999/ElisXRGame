using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOutfitScript2 : MonoBehaviour
{
    public GameObject ChangeButton;

    //Toggles all the other buttons besides change

    //Char buttons
    public GameObject CharA;
    public GameObject CharB;

    //Return to Hub
    public GameObject ReturnToHub;

    public void OpenHubMenu()
    {
        if(ChangeButton != null)
        {
            bool isActive = ChangeButton.activeSelf;
            ChangeButton.SetActive(!isActive);
        }

        if(ReturnToHub != null)
        {
            bool isActive = ReturnToHub.activeSelf;
            ReturnToHub.SetActive(!isActive);
        }

        if(CharA != null)
        {
            bool isActive = CharA.activeSelf;
            CharA.SetActive(!isActive);
        }

        if(CharB != null)
        {
            bool isActive = CharB.activeSelf;
            CharB.SetActive(!isActive);
        }

    }
}
