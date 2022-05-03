using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceUniqueObject : MonoBehaviour
{
    public GameObject objectToCreate;
    public List<Items> placesCanCreate;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random room
        Items RandomPlace = placesCanCreate[Random.Range(0, placesCanCreate.Count)];
        Vector3 RandomPos = RandomPlace.GetRandomPosition();
        Instantiate(objectToCreate, RandomPos, Quaternion.identity);

        print("G-nonymous");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
