using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    public int currEnemyAmount = 0;
    public int maxEnemyAmount = 5;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;


    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0 && currEnemyAmount < maxEnemyAmount)
        {
            SpawnZombie();
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

    }

    void SpawnZombie()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        EnemyAmountUpdate(1);
    }

    public void EnemyAmountUpdate(int addzombieamount)
    {
        currEnemyAmount += addzombieamount;
    }

}