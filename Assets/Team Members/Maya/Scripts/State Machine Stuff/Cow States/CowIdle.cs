using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowIdle : StateBase
{
        
    public StateBase nextState;
    public override void Enter()
    {
        Debug.Log("idle entered");
        base.Enter();
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("idling");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("idle exited");
    }
}
