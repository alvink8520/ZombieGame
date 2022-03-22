using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanderingZombie : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed;

    [SerializeField]
    float range;

    [SerializeField]
    float maxDistance;

    Vector2 wayPoint;

    void Start()
    {
        setNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            setNewDestination();
        }
    }

    void setNewDestination()
    {
        wayPoint = new Vector2(transform.position.x + Random.Range(-maxDistance, maxDistance), transform.position.y + Random.Range(-maxDistance, maxDistance));
    }

   

}
