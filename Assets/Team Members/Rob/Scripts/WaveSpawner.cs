using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

namespace Rob
{
    public class WaveSpawner : MonoBehaviour
    {
        [System.Serializable]
        public class Wave
        {
            public GameObject[] enemies;
            public int count;
            public float timeBetweenSpawns;
        }

        public Wave[] waves;
        public Transform[] spawnPoints;
        public float timeBetweenWaves;
        public List<GameObject> enemyList;

        private Wave currentWave;
        private int currentWaveIndex;
        private Transform UFO;

        private bool spawnFinished;
        
        

        private void Start()
        {
           
            
            UFO = GameObject.Find("PlayerUFO").transform;
            StartCoroutine(StartNextWave(currentWaveIndex));
            
            // subscribe to cow yeeting event, and remove from the enemy<>
        }

        IEnumerator StartNextWave(int index)
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            StartCoroutine(SpawnWave(index));
        }

        IEnumerator SpawnWave(int index)
        {
            // this spawns selected gameobjects according to the parameters we have set
            
            
            currentWave = waves[index];

            for (int i = 0; i < currentWave.count; i++)
            {
                if (UFO == null)
                {
                    yield break;
                }

                GameObject randomEnemy = currentWave.enemies[Random.Range(0, currentWave.enemies.Length)];
                Transform randomTransform = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject spawnedEnemy = Instantiate(randomEnemy, randomTransform.position, randomTransform.rotation);

                enemyList.Add(spawnedEnemy); //adds all spawned objects to a list


                if (i == currentWave.count - 1)
                {
                    spawnFinished = true;
                    StartWave();
                }
                else
                {
                    spawnFinished = false;
                }

                yield return new WaitForSeconds(currentWave.timeBetweenSpawns);
            }
        }

        private void StartWave()
        {
            if (spawnFinished && enemyList.Count <= 0) //
            {
                spawnFinished = false;
                if (currentWaveIndex + 1 < waves.Length)
                {
                    currentWaveIndex++;
                    StartCoroutine(StartNextWave(currentWaveIndex));
                }
                else
                {
                    Debug.Log("you done");
                }
            }
        }

        private void Update()
        {
            //HACK this is just testing to see if waves is working as intended
            if (Input.GetKeyDown(KeyCode.Space))
            {
                enemyList.Clear();
                StartWave();
            }
        }

        //this will be the event called and should? remove said gameobject from the list
        
        public void RemoveFromList()
        {
            enemyList.Remove(gameObject);
        }
        
        
        
    }
}