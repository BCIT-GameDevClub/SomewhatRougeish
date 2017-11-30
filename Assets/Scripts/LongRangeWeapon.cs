using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongRangeWeapon : WeaponBase {

    public GameObject projectilePrefab;
    public Transform shootPos;


    public override void Attack()
    {
        Instantiate(projectilePrefab, shootPos.position, shootPos.rotation); 
    }
}
