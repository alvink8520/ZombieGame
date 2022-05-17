using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class point
{
    public GameObject boxspawner;
}


public class ZombieSpawner : MonoBehaviour
{
    public int enemiesAmount = 0;   
    public int maxEnemyAmount = 5;
    public int timeBetweenSpawn = 0;
    
    public GameObject enemyPrefabs;
    public Camera mainCam;
    Collider2D _collider;

    public List<point> SpawnerPoints;

    //float timer;
    //int waitingTime;

    Vector3 mainCamvector3;
    

    void Start()
    {
        mainCamvector3 = new Vector3(mainCam.orthographicSize * 2 * mainCam.aspect, mainCam.orthographicSize * 2, 0 );
        enemiesAmount = 0;

    }

    void Update()
    {
        if (enemiesAmount < maxEnemyAmount)
        {
            SpawnZombie();
        }
    }


    void SpawnZombie()
    {
        int randspanwer = Random.Range(0, SpawnerPoints.Count);
        Vector3 spawnwerpos = SpawnerPoints[randspanwer].boxspawner.transform.position;

        Instantiate(enemyPrefabs, spawnwerpos, Quaternion.identity);

        enemiesAmount++;

        Debug.Log("spawning");
    }

    public void EnemyAmountUpdate(int addzombieamount)
    {
        enemiesAmount += addzombieamount;
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.magenta;
    //    Gizmos.DrawWireCube(mainCam.transform.position, new Vector3(mainCamvector3.x, mainCamvector3.y, 0f));

    //}
}