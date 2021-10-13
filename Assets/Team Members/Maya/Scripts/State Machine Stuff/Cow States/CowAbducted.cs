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
    }
    public override void Execute()
    {
        base.Execute();
        Debug.Log("still abducted");
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("converted to score");
    }
}
