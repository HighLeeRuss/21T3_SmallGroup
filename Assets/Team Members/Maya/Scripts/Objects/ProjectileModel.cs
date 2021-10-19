using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileModel : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter(Collision hit)
    {
        hit.gameObject.GetComponent<HealthComponent>()?.Damage();
        //sound effect
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
