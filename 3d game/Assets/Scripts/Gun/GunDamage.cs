using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;

    private RaycastHit Shot;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Ammo.CurrentAmmo >= 1)
        {
            
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                TargetDistance = Shot.distance;
                if (TargetDistance < AllowedRange)
                {
                    Shot.transform.SendMessage("Health", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }

}
