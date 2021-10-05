using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthComponent : MonoBehaviour
{
    public delegate void DeathDelegate();

    public event DeathDelegate onDeathEvent;
    // [SerializeField] private float amountHP = 5f;
    //
    // [SerializeField] private float healTimer;
    
    
    
    //Just rearanging things to make life easier
    public float maxHP;
    public float healAmount;
    public float damageAmount;
    [SerializeField] private float currentHP;
    public bool dead;
    
    

    
    
    // Start is called before the first frame update
    //public event Die death;
    void Start()
    {
        //StartCoroutine(AutoHeal());
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // if (Input.GetKeyDown("space"))
        // {
        //     Debug.Log("damage");
        //     Damage();
        // }
        // if (Input.GetKeyDown(KeyCode.LeftShift))
        // {
        //     Debug.Log("heal");
        //     Heal();
        // }
        
        //this is kinda taxing, checking every frame
        
        // if (currentHP <= 0f && dead == false)
        // {
        //     onDeathEvent?.Invoke();
        // }
    }

    public void Damage()
    {
        Debug.Log("ow");
        //healTimer = 2.0f;
        if (currentHP >= 0f)
        {
            currentHP -= damageAmount;
            if (currentHP <= 0 && !dead)
            {
                dead = true;
                currentHP = 0;
                onDeathEvent?.Invoke();
                
            }
        }
    }

    public void Heal()
    {
        if (currentHP < maxHP)
        {
            currentHP += healAmount;
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
        }
    }

    public void DeathFunction()
    {
        onDeathEvent?.Invoke();
    }

    /*{
        Debug.Log("dead");
    }*/

    /*IEnumerator AutoHeal()
    {
        if (currentHP <= maxHP)
        {
            
            currentHP += 2f;
            yield return new WaitForSeconds(1);
            Debug.Log("autoheal");
        }
        else
        {
            yield return null;
        }
    }*/
}
