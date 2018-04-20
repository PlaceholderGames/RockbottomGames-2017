using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : BaseCharacterClass
{
    public float enemyCurrentHealth;

    void Start()
    {
        enemyCurrentHealth = villagerHealth;
    }

    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy()
    {
        enemyCurrentHealth -= characterDamage;
    }
}