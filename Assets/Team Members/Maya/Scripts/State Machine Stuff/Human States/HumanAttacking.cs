using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAttacking : StateBase
{
    private Renderer myMat;
    public StateBase abductedState;
    public StateBase curiousState;
    public override void Enter()
    {
        FindObjectOfType<AbductorCollider>().onHumanAbduction += HitByAbductor;
        Debug.Log("spaceship! throw rocks at it!");
        base.Enter();
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("continuing to throw rocks");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("no longer throwing rocks");
    }
    private void HitByAbductor()
    {
        Debug.Log("human abduction event fired");
        GetComponent<StateManager>().ChangeState(abductedState);
    }
}
