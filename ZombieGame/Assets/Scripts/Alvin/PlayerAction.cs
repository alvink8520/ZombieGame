using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public Rigidbody2D rotationrigidbody;
    public float moveSpeed = 5f;
    public string weapontype;

    private Vector2 lookVector;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }


    public void OnMove(InputValue moveInput)
    {
        Vector2 moveVector = moveInput.Get<Vector2>();
        myrigidbody.velocity = moveVector * moveSpeed;

        if (lookVector.magnitude == 0)
        {
            float lookRadian = Mathf.Atan2(moveVector.y, moveVector.x);

            rotationrigidbody.rotation = (lookRadian * Mathf.Rad2Deg);

        }

    }

    
    public void OnLook(InputValue lookInput)
    {
        
        lookVector = lookInput.Get<Vector2>();

        //keeps the latest direction when right joystick is released
        if(lookVector.magnitude==0)
        {
            return;
        }

        float lookRadian =  Mathf.Atan2(lookVector.y, lookVector.x);

        rotationrigidbody.rotation = (lookRadian * Mathf.Rad2Deg);

        print(rotationrigidbody.rotation);




    }

    public void OnAttack(InputValue attackInput)
    {
        

    }
}
