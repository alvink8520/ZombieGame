using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerahandler : MonoBehaviour
{
    [Header("Max Distance to pickup a Weapon")]
    public float MaxDistance = 3;
    [Header("Pick key")]
    public KeyCode PickUpKey = KeyCode.F;


    // Players Info
    private GameObject Player;
    private GameObject PlayerCamera;

    [Header("Other Scripts")]
    private gunhandler GunH;
    private weaponhandler WeaponH;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        WeaponH = Player.gameObject.GetComponent<weaponhandler>();
        PlayerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PickUpKey))
        {
            ShootRayCast();
        }
    }

    void ShootRayCast()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.gameObject.transform.position, this.gameObject.transform.forward, out hit, MaxDistance))
        {

            GunH = hit.transform.GetComponent<gunhandler>();
            if (GunH != null)
            {
                if (WeaponH.hasweapon == false)
                {
                    GunH.PickUpAction();
                    GunH = null;
                    return;
                }
                if (WeaponH.hasweapon == true)
                {
                    WeaponH.WhenHasWeapon();
                    GunH.PickUpAction();

                    GunH = null;

                    return;
                }
            }
        }
    }
}