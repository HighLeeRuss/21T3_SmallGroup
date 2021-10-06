using System;
using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class HumanModel : MonoBehaviour
{

    private Renderer myMat;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AbductorCollider>().onHumanAbduction += HumanAbduct;
        myMat = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HumanAbduct()
    {
        Debug.Log("oh god the humanity");
        //Renderer myRend = GetComponent<Renderer>();
        myMat.material.SetColor("_Color", Color.magenta);
    }
}
