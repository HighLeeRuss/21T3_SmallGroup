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
        Debug.Log("cow is scared");
        FindObjectOfType<AbductorCollider>().onCowAbduction += HitByAbductor;
    }
    
    public override void Execute()
    {
        base.Execute();
        Debug.Log("cow is still scared");
    }
    public override void Exit()
    {
        base.Exit();
        //GetComponent<StateManager>().ChangeState(nextState);
        //stop listening 
    }
    private void HitByAbductor()
    {
        Debug.Log("hit by an abductor");
        GetComponent<StateManager>().ChangeState(abductedState);
    }
}
