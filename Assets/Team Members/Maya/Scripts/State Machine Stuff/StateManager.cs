using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public StateBase currentState;

    public StateBase nextStateTest;
    // Start is called before the first frame update
    public void ChangeState(StateBase nextState)
    {
        Debug.Log("next state");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
