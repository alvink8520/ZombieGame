using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueObject : MonoBehaviour
{
    public GameObject objectToCreate;
    public List<ItemSpawner> placesCanCreate;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random room
        ItemSpawner RandomPlace = placesCanCreate[Random.Range(0, placesCanCreate.Count)];
        Vector3 RandomPos = RandomPlace.GetRandomPosition();
        Instantiate(objectToCreate, RandomPos, Quaternion.identity);

        print("G-nonymous");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
