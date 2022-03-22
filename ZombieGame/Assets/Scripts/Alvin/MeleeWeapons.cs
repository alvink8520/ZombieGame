using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public string name;
    public int minDamage;
    public int maxDamage;
}


public class MeleeWeapons : MonoBehaviour
{

    public List<Weapon> weapons;
}
