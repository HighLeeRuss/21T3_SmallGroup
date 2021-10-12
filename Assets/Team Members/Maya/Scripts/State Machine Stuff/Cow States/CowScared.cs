using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScared : StateBase
{
    public override void Enter()
    {
        //set movement speed high
        //set waypoint away from thingThatScaredMe
    }
    public override void Execute()
    {
        //check for continued danger
        //if there is, Enter()
        //if theres not, drop movement speed back to idle
        //if you are hit by an abductor, Exit()
    }
    public override void Exit()
    {
        //become idle
        //become abducted if in contact with an abductor
    }
}
