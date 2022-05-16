using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueItemSpawn : MonoBehaviour
{
    public GameObject objectToCreate;
    public List<ItemSpwan> placesCanCreate;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random room
        ItemSpwan RandomPlace = placesCanCreate[Random.Range(0, placesCanCreate.Count)];
        Vector3 RandomPos = RandomPlace.GetRandomPosition();
        Instantiate(objectToCreate, RandomPos, Quaternion.identity);

        print("An unique Item is here!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
