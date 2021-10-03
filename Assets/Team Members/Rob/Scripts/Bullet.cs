using System;
using System.Collections;
using System.Collections.Generic;
using Rob;
using UnityEngine;

namespace Rob
{

    public class Bullet : MonoBehaviour
    {
        public float speed;
        private GameObject UFO;
        
        private Rigidbody rb;

        // Start is called before the first frame update

        private void Awake()
        {
            UFO = GameObject.Find("PlayerUFO");
        }

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            rb.AddForce(transform.forward * speed);
            StartCoroutine(Timer());


            // if (Vector3.Distance(transform.position, UFO.transform.position) > .1f)
            // {
            //     transform.position = Vector3.MoveTowards(transform.position, UFO.transform.position, speed * Time.deltaTime);
            // }
            // else
            // {
            //     Destroy (gameObject);
            // }
        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider col)
        {
            col.gameObject.GetComponent<HealthComponent>()?.Damage();
            Destroy(gameObject);
            //sound effect
        }
    }
}
