using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAbducted : StateBase
{
    private Renderer myMat;
    //public StateBase brainwashedState;
    public StateBase idleState;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("you unfortunately abducted a primate");
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("still going");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("brainwashed");
    }
}
