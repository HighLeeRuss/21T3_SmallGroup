using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision hit)
    {
        hit.gameObject.GetComponent<HealthComponent>()?.Damage();
        //sound effect
    }
}
