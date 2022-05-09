using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public string name;
    public int attackSpeed;
    public int KnockBack;
    public int minDamage;
    public int maxDamage;
}


public class Weapons : MonoBehaviour
{
    public List<Weapon> weapons;
    public List<Weapon> rangedweapons;
}



