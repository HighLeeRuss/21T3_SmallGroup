using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public delegate void Die();

public class HealthComponent : MonoBehaviour
{
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
            Die();
        }
    }

    public void Damage(float amountHP = -5f)
    {
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

    public void Die()
    {
        dead = true;
        //disable controls
        //record final score
        //lerp ship up and away
        /*var position = transform.position;
        float lerp = Mathf.Lerp(position.y, position.y +10f, 20f);
        position = new Vector3(0, lerp, 0) + position;
        transform.position = position;*/
        Debug.Log("dead");
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
