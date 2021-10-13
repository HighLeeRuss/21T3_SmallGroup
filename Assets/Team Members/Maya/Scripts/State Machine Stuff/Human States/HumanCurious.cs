using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanCurious : StateBase
{

    public StateBase attackingState;
    public StateBase idleState;
    public override void Enter()
    {
        Debug.Log("curious enter");
        base.Enter();
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("curious executing");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("curious exit");
    }
}
