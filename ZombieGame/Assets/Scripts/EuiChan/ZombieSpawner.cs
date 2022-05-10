using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public int enemiesAmount = 0;
    public int maxEnemyAmount = 0;
    public int timeBetweenSpawn = 0;
    
    public GameObject enemyPrefabs;
    public Camera cam;

    float timer;
    int waitingTime;
    //public float startTimeBtwSpawns;
    //private float timeBtwSpawns;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        enemiesAmount = 0;
        //timeBtwSpawns = startTimeBtwSpawns;



    }

    // Update is called once per frame
    void Update()
    {
        float height = cam.orthographicSize +4;
        float width = height * cam.aspect;
        if (enemiesAmount <= 5)
        {
            for (enemiesAmount = 0; enemiesAmount < maxEnemyAmount; enemiesAmount++)
            {
                Instantiate(enemyPrefabs, new Vector3(cam.transform.position.x + Random.Range(-width, width), 3, cam.transform.position.z + height + Random.Range(10, 30)), Quaternion.identity);
                

            }
        }

        /*if (timeBtwSpawns <= 0)
        {
           
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }*/
    }
}