using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Staircase : MonoBehaviour
{

    GameObject player;
    Rigidbody2D playerrigidbody;

    // level 2 Middle, Left, Right
    Vector2 stair = new Vector2(-23f, 109f);
    Vector2 stair1 = new Vector2(-131f, 138f);
    Vector2 stair2 = new Vector2(-9.5f, 146f);

    // level 1 Middle, Left, Right
    Vector2 stair3 = new Vector2(-55f, 28f);
    Vector2 stair4 = new Vector2(-95f, 36f);
    Vector2 stair5 = new Vector2(14f, 36f);


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerrigidbody = player.GetComponent<Rigidbody2D>();
    }

    //public string levelToLoad;
    public Vector3 newPos;

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the player hit the staircase
       if(other.gameObject == player)
        {
            // MOve the player's position
            player.transform.position = newPos;
        }

        //if(other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair");
        //    transform.position = Vector2.MoveTowards(transform.position, stair, 0.1f);
        //}
        //else if(other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair1");
        //    transform.position = Vector2.MoveTowards(transform.position, stair1, 0.1f);
        //}
        //else if (other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair2");
        //    transform.position = Vector2.MoveTowards(transform.position, stair2, 0.1f);
        //}
        //else if (other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair3");
        //    transform.position = Vector2.MoveTowards(transform.position, stair3, 0.1f);
        //}
        //else if (other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair4");
        //    transform.position = Vector2.MoveTowards(transform.position, stair4, 0.1f);
        //}
        //else if (other == player)
        //{
        //    player = GameObject.FindGameObjectWithTag("stair5");
        //    transform.position = Vector2.MoveTowards(transform.position, stair5, 0.1f);
        //}
    }

    void Update()
    {

    }
}
