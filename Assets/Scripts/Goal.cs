using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal 
//Goal system, not a monobehavior
//Source: https://www.youtube.com/watch?v=up6HcYph_bo&list=PLtEzwdBEwtJfEMI7uL9hCxH1udUYPqEoC
{
    //Properties
    public string Description { get; set;} 
    //Describes the goal, gets the goal from something, and then set it on the mission panel
    public bool Completed { get; set;} 
    //Checks if that goal was complete
    public float CurrentAmount { get; set;} 
    //How much of our goal that we currently did
    public float RequiredAmount { get; set;} 
    //How much of our goal that we need to do

    public virtual void Init()
    //Initizialization method
    {
        //default Init Stuff
        //Will have a function for more complex quests
    }


    public void Evaluate()
    //Function that checks variables CurrentAmount vs RequiredAmount
    {
        if (CurrentAmount >= RequiredAmount)
        {
            //if True, call for Complete function
            Complete();
        }
    }

    public void Complete()
    {
        Completed = true;
    }

}
