using System;
using System.Collections;
using System.Collections.Generic;
using Rob;
using UnityEngine;

public class AbductorCollider : MonoBehaviour

{
<<<<<<< HEAD
    public delegate void CowDelegate();
    public delegate void HumanDelegate();
    public event CowDelegate onCowAbduction;
    public event HumanDelegate onHumanAbduction;
=======
    
>>>>>>> 564fc6975eb1b174265226a05d22ca1d70907253

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<CowModel>())
        {
            //Debug.Log("cow");
            onCowAbduction?.Invoke();
        }

        if (other.gameObject.GetComponentInParent<HumanMove>())
        {
            //Debug.Log("human");
            onHumanAbduction?.Invoke();
            //human abduction shit happens
        }
    }
}