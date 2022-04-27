using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    public GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        // if we forgot to put vfx it will not be effected
        if (!deathVFX)
        {
            return;
        }

        // destroying the particle 
        GameObject go = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(go, 1.5f);
    }
}