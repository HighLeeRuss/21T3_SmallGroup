using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public StateBase currentState; 
    
    
    public void ChangeState(StateBase newState)
    {
        //Debug.Log("next state");
        //if you have a state right now, Exit();
        if (currentState != null)
        {
            currentState.Exit();
        }

        if (newState != null)
        {
            newState.Enter();
            currentState = newState;
        }
        //currentState = newState
        //currentState.Enter();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != null)
        {
            currentState.Execute();
        }
    }
}
