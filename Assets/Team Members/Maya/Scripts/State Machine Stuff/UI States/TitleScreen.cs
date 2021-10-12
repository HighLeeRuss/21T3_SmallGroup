using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleScreen : StateBase
{
    // Start is called before the first frame update
    public override void Enter()
    {
        this.gameObject.SetActive(true);
    }
    public override void Execute()
    {
        
    }
    public override void Exit()
    {
        this.gameObject.SetActive(false);
    }
}
