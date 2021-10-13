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
        //currentState = newState
        //currentState.Enter();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if you have 
    }
}
