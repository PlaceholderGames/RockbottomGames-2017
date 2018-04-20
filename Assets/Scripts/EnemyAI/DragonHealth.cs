using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : BaseCharacterClass
{
    public static float dragonCurrentHealth;
    public GameObject killMessage;

    void Start()
    {
        dragonCurrentHealth = dragonHealth;
    }

    void Update()
    {   
        if (dragonCurrentHealth <= 0)
        {
            killMessage.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void DamageEnemy()
    {
        dragonCurrentHealth -= characterDamage;
    }
}

