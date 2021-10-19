using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowIdle : StateBase
{
    public StateBase scaredState;
    public StateBase idleState;
    public override void Enter()
    {
        Debug.Log("idle entered");
        base.Enter();
        FindObjectOfType<SoundComponent>().onCowHeard += HeardPlayer;
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

    private void HeardPlayer()
    {
        Debug.Log("cow hears a spaceship");
        GetComponent<StateManager>().ChangeState(scaredState);
    }
}
