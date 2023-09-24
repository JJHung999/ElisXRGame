using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeUIText : MonoBehaviour
{
    //Source: https://www.youtube.com/watch?v=r2TB_6zIxvY

    //UI Text Game objects
    public GameObject GoalObj;
    public GameObject GoalNum;

    //Game Variables
    public string objective_a;
    public float rep;

    // Text Components
    TextMeshProUGUI textmeshpro_objective_text;
    TextMeshProUGUI textmeshpro_rep_text;

    // Start is called before the first frame update
    void Start()
    {
        //Text Mesh Pro, accesses the TMP element to pull the component of that UI
        //So that it can change the number on the UI
        textmeshpro_objective_text = GoalObj.GetComponent<TextMeshProUGUI>();
        textmeshpro_rep_text = GoalNum.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Text Mesh Pro
        textmeshpro_objective_text.text = objective_a;
        textmeshpro_rep_text.text = rep.ToString();
    }
    void Awake ()
    {
        DontDestroyOnLoad (this.gameObject);
    }
}
