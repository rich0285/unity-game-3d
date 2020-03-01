using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float EnemyHealth = 50;


    private float dmg = 100f;

    public void TakeDamage(float DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if (EnemyHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        c.gameObject.GetComponent<PM>().TakeDamage(dmg);
       
    }
}
