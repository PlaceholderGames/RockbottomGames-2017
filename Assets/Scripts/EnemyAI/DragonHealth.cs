using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : BaseCharacterClass
{
    public static float dragonCurrentHealth;

    void Start()
    {
        dragonCurrentHealth = dragonHealth;
    }

    void Update()
    {   
        if (dragonCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy()
    {
        dragonCurrentHealth -= characterDamage;
    }
}

