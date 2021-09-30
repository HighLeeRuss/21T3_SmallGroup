using System;
using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;


public class Behave : MonoBehaviour
{

    public bool agitate;
    public bool seeUfo;
    public int anger;




    public void Attack()
    {
        Debug.Log("Attack");
    }


    public void Agitate()
    {
        if (agitate)
        {
            StartCoroutine(AddAgitate());
        }
    }

    IEnumerator AddAgitate()
    {
        anger += 5;
        yield return new WaitForSeconds(1);
    }

    public void ResetAnger()
    {
        agitate = false;
        anger = 0;
    }
     
}
