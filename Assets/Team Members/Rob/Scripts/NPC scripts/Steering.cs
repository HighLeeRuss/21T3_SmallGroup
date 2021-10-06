using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rob;
using Random = UnityEngine.Random;

public class Steering : MonoBehaviour
{
    private Rigidbody rb;
    public float torque;
    public float checkDist;
    public float checkDistLeft;
    public float checkDistRight;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0,Random.Range(0f,360f),0));
    }


    void Update()
    {
        Ray rayForward = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(transform.position, transform.forward * checkDist, Color.black);
        
        Ray rayLeft = new Ray(this.transform.position, transform.forward - transform.right);
        Debug.DrawRay(transform.position, (transform.forward + transform.right) * checkDistRight, Color.red);
        
        Ray rayRight = new Ray(this.transform.position, transform.forward + transform.right);
        Debug.DrawRay(transform.position, (transform.forward - transform.right) * checkDistLeft, Color.red);
        

        RaycastHit hit;

        if (Physics.Raycast(rayForward, out hit, checkDist))
        {
            rb.AddRelativeTorque(Vector3.up * torque);
        }

        if (Physics.Raycast(rayRight, out hit, checkDistRight))
        {
            rb.AddRelativeTorque(Vector3.up * torque);
        }

        if (Physics.Raycast(rayLeft, out hit, checkDistLeft))
        {
            rb.AddRelativeTorque(Vector3.up * torque);
        }
    }

    void OnDrawGizmos()
    {
        
        
        
    }
}