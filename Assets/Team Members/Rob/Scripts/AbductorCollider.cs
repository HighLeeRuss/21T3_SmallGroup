using System;
using System.Collections;
using System.Collections.Generic;
using Rob;
using UnityEngine;

public class AbductorCollider : MonoBehaviour

{

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<CowModel>())
        {
            Debug.Log("cow");
            //game manager adds score to player
            Destroy(other.transform.parent.gameObject);
        }

        if (other.gameObject.GetComponentInParent<HumanMove>())
        {
            Debug.Log("human");
            //human abduction shit happens
        }
    }
}