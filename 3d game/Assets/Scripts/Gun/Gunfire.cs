using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    private float endReload = 3;
    private bool isReloading= false;
    private int maxAmmo = 30;

    void Start()
    {
        Ammo.CurrentAmmo = 30;
        }

    void Update()
    {
        if (isReloading)
        {
            return;
        }


        if (Input.GetButtonDown("Fire1") && Ammo.CurrentAmmo >= 1)
        {
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("GunShot");
            Ammo.CurrentAmmo -= 1;

        }
       
        if (Input.GetKeyDown("r") && Ammo.CurrentAmmo == 0)
        {
            isReloading = true;
            StartCoroutine(Reload());
            
            isReloading = false;
        }
       
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(endReload);
        Ammo.CurrentAmmo = maxAmmo;
    }
}
