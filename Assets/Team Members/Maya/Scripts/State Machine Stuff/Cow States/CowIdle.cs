using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowIdle : StateBase
{
        
    public StateBase nextState;
    public override void Enter()
    {
        Debug.Log("idle entered");
        //set movement speed low
        //random waypoint set
    }
    public override void Execute()
    {
        //wander and stop code
        //eat grass animation when you stop
        //listen for ufo, scared cows and humans
        //if any of them exit()
    }
    public override void Exit()
    {
        Debug.Log("idle exited");
        //become scared
    }
}
