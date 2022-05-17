using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    public spawner _spawner;
    GameObject gamemanager;

    public Animator myAnimator;
    public Rigidbody2D myrigidbody;
    public Rigidbody2D rotationrigidbody;
    public BoxCollider2D mycollider2D;

    public float moveSpeed = 5f;
    public string weapontype;

    public bool meleeAttack;
    public bool rangedAttack;

    private Vector2 lookVector;
    private Vector2 moveVector; 

    void Start()
    {
        gamemanager = GameObject.Find("GameManager");
        _spawner = gamemanager.GetComponent<spawner>();
        myrigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mycollider2D = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        if (moveVector.magnitude == 0)
        {
            myAnimator.SetBool("IsWalking", false);
        }
        else if (moveVector.magnitude != 0)
        {
            myAnimator.SetBool("IsWalking", true);
        }

        if (lookVector.magnitude != 0)
        {
            myAnimator.SetBool("IsMeleeAtk", true);
        }
        else if (moveVector.magnitude == 0)
        {
            myAnimator.SetBool("IsMeleeAtk", false);
        }

    }


    public void OnMove(InputValue moveInput)
    {

        if (lookVector.magnitude == 0)
        {
            float lookRadian = Mathf.Atan2(moveVector.y, moveVector.x);

            rotationrigidbody.rotation = (lookRadian * Mathf.Rad2Deg -90);

        }
        else if (moveVector.magnitude == 0)
        {
            return;
        }

        moveVector = moveInput.Get<Vector2>();
        myrigidbody.velocity = moveVector * moveSpeed;
    }

    
    public void OnLook(InputValue lookInput)
    {
        
        lookVector = lookInput.Get<Vector2>();

        //keeps the latest direction when right joystick is released
        if(lookVector.magnitude==0)
        {
            return;
        }
        else if (lookVector.magnitude == 0 )
        {
            Attack(mycollider2D);
            print("Attack!!");
        }
        //else if(lookVector.magnitude !=0)
        //{
        //    OnAttack(InputValue);
        //}

        float lookRadian =  Mathf.Atan2(lookVector.y, lookVector.x);

        rotationrigidbody.rotation = (lookRadian * Mathf.Rad2Deg -90);

        //print(rotationrigidbody.rotation);

    }

    public void OnAttack(InputValue attackInput)
    {
        Attack(mycollider2D);
        print("Attack!!");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (lookVector.magnitude != 0 && collision.gameObject.CompareTag("Enemy"))
        {
            GameObject.Destroy(collision.gameObject);

            //temp solution, need to change in to damage int
            _spawner.EnemyAmountUpdate(-1);
        }
    }

    public void Attack(Collider2D other)
    {
        //GameObject.Destroy(other);
        //print("hit");
        //if (other.tag == "Enemy")
        //{
        //    GameObject.Destroy(other);
        //    print("hit");
        //}
        //if (meleeAttack == true)
        //{
        //    if(other.tag == "Enemy")
        //    {
        //        GameObject.Destroy(other);
        //        print("hit");
        //    }
        //    return;
        //}
        //else if (rangedAttack == true)
        //{
        //    return;
        //}
    }
}
