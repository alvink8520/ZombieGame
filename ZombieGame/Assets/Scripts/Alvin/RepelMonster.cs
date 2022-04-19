using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepelMonster : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Enemy_Wander.followPlayer = false;
    }

    void OnTriggerExit2D()
    {
        Enemy_Wander.followPlayer = true;
    }
}
