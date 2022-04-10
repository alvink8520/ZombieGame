using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Animator))]

public class Enemy_Wander : MonoBehaviour
{
    public float pursuitSpeed;
    public float wanderSpeed;
    public float currentSpeed;

    public float directionChangeInterval;
    public bool followPlayer;

    Coroutine moveCoroutine;
    CircleCollider2D CircleCollider2D;
    Rigidbody2D Rb;
    Animator animator;

    Transform targetTransform = null;
    Vector3 endPosition;
    float currentAngle = 0;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
        CircleCollider2D = GetComponent<CircleCollider2D>();
        currentSpeed = wanderSpeed;
        StartCoroutine(WanderRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Rb.position, endPosition, Color.red);
    }

    public IEnumerator WanderRoutine()
    {
        while (true)
        {
            ChooseNewEndPoint();

            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }
            moveCoroutine = StartCoroutine(Move(Rb, currentSpeed));

            yield return new WaitForSeconds(directionChangeInterval);
        }
    }

    void ChooseNewEndPoint()
    {
        currentAngle += Random.Range(0, 360);
        currentAngle = Mathf.Repeat(currentAngle, 360);
        endPosition += Vector3FromAngle(currentAngle);
    }

    Vector3 Vector3FromAngle(float inputAngleDegress)
    {
        float inputAngleRadians = inputAngleDegress * Mathf.Deg2Rad;

        return new Vector3(Mathf.Cos(inputAngleRadians), Mathf.Sin(inputAngleRadians), 0);
    }

    public IEnumerator Move(Rigidbody2D rigidBodyToMove, float speed)
    {
        float remainingDistance = (transform.position - endPosition).sqrMagnitude;

        while(remainingDistance > float.Epsilon)
        {
            if(targetTransform != null)
            {
                endPosition = targetTransform.position;
            }

            if(rigidBodyToMove != null)
            {
                animator.SetBool("isMove", true);
                Vector3 newPosition = Vector3.MoveTowards(rigidBodyToMove.position, endPosition, speed * Time.deltaTime);

                Rb.MovePosition(newPosition);
                remainingDistance = (transform.position - endPosition).sqrMagnitude;
            }
            yield return new WaitForFixedUpdate();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && followPlayer)
        {
            currentSpeed = pursuitSpeed;
            targetTransform = collision.gameObject.transform;
            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }

            moveCoroutine = StartCoroutine(Move(Rb, currentSpeed));
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isMove", false);
            currentSpeed = wanderSpeed;

            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }
            targetTransform = null;
        }
    }

    void OnDrawGizmos()
    {
        if(CircleCollider2D != null)
        {
            Gizmos.DrawWireSphere(transform.position, CircleCollider2D.radius);
        }
    }
}
