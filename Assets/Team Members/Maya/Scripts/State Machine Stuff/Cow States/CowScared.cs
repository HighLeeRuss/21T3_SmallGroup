using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScared : StateBase
{
    //public int x;
    public StateBase idleState;
    public StateBase abductedState;
    //public StateBase nextState;
    public override void Enter()
    {
        base.Enter();
        //nextState = idleState;
        FindObjectOfType<AbductorCollider>().onCowAbduction += HitByAbductor;
        //change colour
        //set movement speed high
        //set waypoint away from thingThatScaredMe
        //activate scaredRun
        //listen for events that change state
    }
    
    public override void Execute()
    {
        base.Execute();
    }
    public override void Exit()
    {
        base.Exit();
        //GetComponent<StateManager>().ChangeState(nextState);
        //stop listening 
    }
    private void HitByAbductor()
    {
        //add score to abducting player
        //play animation
        Debug.Log("congratufuckinglations");
        //nextState = abductedState;
        //this.enabled = false;
    }
}
