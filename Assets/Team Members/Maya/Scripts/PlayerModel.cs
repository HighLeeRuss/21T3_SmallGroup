using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{ 
    void Awake()
    {
        GetComponent<HealthComponent>().onDeathEvent += Die;
    }

    public void Die()
    {
        GetComponent<HealthComponent>().DeathFunction();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
