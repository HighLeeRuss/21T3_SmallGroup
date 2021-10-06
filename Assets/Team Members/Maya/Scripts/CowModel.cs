using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowModel : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AbductorCollider>().onCowAbduction += CowAbduct;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CowAbduct()
    {
        Debug.Log("moo");
    }
}
