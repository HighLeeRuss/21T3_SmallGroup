using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Wander : MonoBehaviour
{
    private Rigidbody rb;
    private float perlin;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        perlin = Mathf.PerlinNoise( Random.Range(0f, 1000f) + Time.time, 0) -.5f;
        rb.AddRelativeTorque(0f, perlin, 0f);
    }
}