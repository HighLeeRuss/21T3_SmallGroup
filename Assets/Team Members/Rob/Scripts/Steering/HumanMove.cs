using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Rob
{


    public class HumanMove : MonoBehaviour
    {
        
        private float attackTime;
        private Animator anim;
        private Vector2 position;
        private Rigidbody rb;
        
        public Transform ufoTransform;
        // public Transform shotPoint;
        // public GameObject enemyBullet;
        public GameObject UFO;
        public float stopDistance;
        public float speed;
        public float timeBetweenAttacks;
        
        

        


        public void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (UFO != null)
            {
                if (Vector3.Distance(transform.position, ufoTransform.position) > stopDistance)
                {
                    transform.LookAt(ufoTransform);
                    rb.AddForce(transform.forward * speed);
                }

                else
                {
                    if (Time.time >= attackTime)
                    {
                        attackTime = Time.time + timeBetweenAttacks;
                        RangedAttack();
                    }
                }
            }
            
        }

      public void RangedAttack()
       {
           Debug.Log("shot");
      //     Vector2 direction = ufoTransform.position - shotPoint.position;
      //     float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      //     Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
      //     shotPoint.rotation = rotation;
      //     anim.SetTrigger("Attack");

      //     Instantiate(enemyBullet, shotPoint.position, shotPoint.rotation);
       }
        
    }
}


