 ﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{

    public KeyCode EquipPrimary = KeyCode.Alpha1;
    public KeyCode EquipSecondary = KeyCode.Alpha2;

    [Header("Primary and Secondary")]
    public GameObject Primary;
    public GameObject Secondary;

    [HideInInspector]
    public string CurrentWeapon;
    [HideInInspector]
    public GameObject DropPrefab;
    [HideInInspector]
    public GameObject WeaponInHand;
    private GameObject NewGunPrefab;
    [HideInInspector]
    public bool hasweapon = false;
    [HideInInspector]
    public List<GameObject> GunsList = new List<GameObject>();


    private  bool PrimaryWeaponEquipped = true;
    private  bool SecondaryWeaponEquipped = false;




    void Awake()
    {
      foreach (Transform child in Primary.transform)
      {
          GunsList.Add(child.gameObject);
      }
      foreach (Transform child in Secondary.transform)
      {
          GunsList.Add(child.gameObject);
      }

      Primary.SetActive(true);
      Secondary.SetActive(false);
    }

    void Update()
    {
      if(Input.GetKeyDown(EquipPrimary))
      {
        PrimaryWeaponEquipped = ! PrimaryWeaponEquipped;
        SecondaryWeaponEquipped = false;
        EquipPrimaryWeapon();
      }
      else if (Input.GetKeyDown(EquipSecondary))
      {
          SecondaryWeaponEquipped = ! SecondaryWeaponEquipped;
          PrimaryWeaponEquipped = false;
          EquipPrimaryWeapon();
      }
    }

    void EquipPrimaryWeapon()
    {
      if(PrimaryWeaponEquipped == true)
      {
        Primary.SetActive(true);
      } else if (PrimaryWeaponEquipped == false)
      {
        Primary.SetActive(false);

      }

      if(SecondaryWeaponEquipped == true)
      {
        Secondary.SetActive(true);
      } else
      {
        Secondary.SetActive(false);

      }

    }

    public void WhenHasWeapon ()
    {
      if(DropPrefab != null)

      {
        NewGunPrefab = Instantiate(DropPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
      }
      else
      {
        Debug.Log("There is no drop prefab");
      }

      hasweapon = false;
      WeaponInHand.SetActive(false);
    }
}

//YouTube Channel Twin Gaming Studios