using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Source: https://www.youtube.com/watch?v=tF9RMjF9wDc

public class UIFadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    public void ShowUI()
    {
        myUIGroup.alpha = 1;
    }

    public void HideUI()
    {
        myUIGroup.alpha = 0;
    }
    void Awake ()
    {
        DontDestroyOnLoad (this.gameObject);
    }
}
