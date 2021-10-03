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

        public Transform shotPoint;
        public GameObject enemyBullet;
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
                transform.LookAt(UFO.transform.position);
                
                if (Vector3.Distance(transform.position, UFO.transform.position) > stopDistance)
                {
                    rb.AddForce(transform.forward * speed);
                }
                else 
                
                if (Time.time >= attackTime)
                {
                    attackTime = Time.time + timeBetweenAttacks;
                    RangedAttack();
                }
            }
        }

        public void RangedAttack()
        {
            Debug.Log("shot");
            Instantiate(enemyBullet, shotPoint.position, shotPoint.rotation);
        }
    }
}