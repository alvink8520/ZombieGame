using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHandler : MonoBehaviour
{
    

    [Header("Gun Settings")]
    public string WeaponName;
    public GameObject DropWeaponPrefab;

    private GameObject Player;
    private GameObject InventoryGun;
    private WeaponHandler WeaponH;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        WeaponH = Player.gameObject.GetComponent<WeaponHandler>();


        InventoryGun = WeaponH.GunsList.Find(obj=>obj.name==WeaponName);
        InventoryGun.SetActive(false);

        return;
    }

    public void PickUpAction()
    {

        WeaponH.DropPrefab = DropWeaponPrefab;
        WeaponH.WeaponInHand = InventoryGun;
        WeaponH.CurrentWeapon = WeaponName;

        InventoryGun.SetActive(true);
        WeaponH.hasweapon = true;
        Destroy(gameObject);
        return;
    }
}

//YouTube Channel Twin Gaming Studios