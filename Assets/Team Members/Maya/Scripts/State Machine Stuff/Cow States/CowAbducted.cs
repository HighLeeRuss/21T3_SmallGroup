using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CowAbducted : StateBase
{
    public StateBase nextState;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("you successfully abducted a cow");
        //set movement speed to 0
        //play animation
        //moo
    }
    public override void Execute()
    {
        base.Execute();
        //add 1 to abducting players score
        //moo
    }
    public override void Exit()
    {
        base.Exit();
        //sad moo
        //destroy self
    }
}
