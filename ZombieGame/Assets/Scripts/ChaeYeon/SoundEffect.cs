using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappingHook : MonoBehaviour
{
    public LineRenderer line;
    public Transform hook;
    Vector2 mousedir;

    public AudioClip clip;

    public bool isHookActive;
    public bool isLineMax;
    public bool isAttach;

    private void Start()
    {
        line.positionCount = 2;
        line.endWidth = line.startWidth = 0.05f;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        line.useWorldSpace = true;
        isAttach = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isHookActive)
        {
            hook.position = transform.position;
            mousedir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            isHookActive = true;
            isLineMax = false;
            hook.gameObject.SetActive(true);

            SoundManager.instance.SFXPlay("Hook", clip);
        }

        if (isHookActive && !isLineMax && !isAttach)
        {
            hook.Translate(mousedir.normalized * Time.deltaTime * 15);

            if (Vector2.Distance(transform.position, hook.position) > 5)
            {
                isLineMax = true;
            }

        }
        else if (isHookActive && isLineMax && !isAttach)
        {

        }
    }
}


