using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : BaseCharacterClass
{
    public static int dragonCurrentHealth;


    void Start()
    {
        dragonCurrentHealth = dragonHealth;
    }

    void Update()
    {   
        //checks if play is dead.
        if (dragonCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy(int damage)
    {
        dragonCurrentHealth -= damage;
    }
}

