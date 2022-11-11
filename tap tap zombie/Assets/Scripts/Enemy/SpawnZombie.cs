using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    [SerializeField] Zombie zombiePrefab;
    [SerializeField] Transform[] spawnPoint;
    [SerializeField] float minSpawnTime;
    [SerializeField] float maXSpawnTime;

    [SerializeField] float spawnTimeOut;

    

    // Update is called once per frame
    void Update()
    {
      if(spawnTimeOut > 0)
      {
            spawnTimeOut -= Time.deltaTime;
      }
      else
      {
            spawnTimeOut = Random.Range(minSpawnTime, maXSpawnTime);
            Instantiate(zombiePrefab, spawnPoint[Random.Range(0, spawnPoint.Length)]);
      }

    }
}
