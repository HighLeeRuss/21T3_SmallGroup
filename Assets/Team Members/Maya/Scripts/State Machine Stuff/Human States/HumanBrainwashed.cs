using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBrainwashed : StateBase
{
    private Renderer myMat;
    public StateBase attackingState;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("brainwashed entered");
    }
    public override void Execute()
    {
        base.Execute();
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("brainwashed exited");
    }
}
