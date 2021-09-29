using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthComponent : MonoBehaviour
{
    public delegate void DeathDelegate();

    public event DeathDelegate onDeathEvent;
    [SerializeField] private float amountHP = 5f;

    [SerializeField] private float healTimer;
    [SerializeField] private float currentHP;

    public bool dead = false;

    public float maxHP = 25f;
    // Start is called before the first frame update
    //public event Die death;
    void Start()
    {
        //StartCoroutine(AutoHeal());
        currentHP = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("damage");
            Damage(amountHP);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("heal");
            Heal(amountHP);
        }

        if (currentHP <= 0f && dead == false)
        {
            onDeathEvent?.Invoke();
        }
    }

    public void Damage(float amountHP = -2f)
    {
        Debug.Log("ow");
        //healTimer = 2.0f;
        if (currentHP >= 0f)
        {
            currentHP += amountHP;
        }
    }

    public void Heal(float amountHP = 5f)
    {
        if (currentHP <= maxHP && amountHP >0f)
        {
            currentHP += amountHP;
            if (currentHP >= maxHP)
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
