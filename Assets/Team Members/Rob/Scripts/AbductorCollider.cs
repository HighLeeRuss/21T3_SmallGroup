using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbductorCollider : MonoBehaviour

{
    public GameObject cow;
    public GameObject human;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cow)
        {
            Debug.Log("cow");
            //game manager adds score to player
        }

        if (other.gameObject == human)
        {
            Debug.Log("human");
            //human abduction shit happens
        }
    }
}