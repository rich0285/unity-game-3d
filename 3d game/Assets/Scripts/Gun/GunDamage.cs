using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Ammo.CurrentAmmo >= 1)
        {
            Shoot();
        }
        
        void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                EnemyScript target = hit.transform.GetComponent<EnemyScript>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
            }
        }

    }

}
