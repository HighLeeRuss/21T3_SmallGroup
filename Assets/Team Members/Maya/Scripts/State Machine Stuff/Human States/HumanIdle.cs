using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanIdle : StateBase
{

    public StateBase curiousState;
    public override void Enter()
    {
        Debug.Log("human idle entered");
        base.Enter();
        FindObjectOfType<SoundComponent>().onHumanHeard += HeardPlayer;
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("human idling");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("human idle exited");
    }
    private void HeardPlayer()
    {
        Debug.Log("human hears a spaceship");
        GetComponent<StateManager>().ChangeState(curiousState);
    }
}
