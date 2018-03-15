using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : BaseCharacterClass
{
    public int enemyCurrentHealth;

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

    public void DamageEnemy (int damage)
    {
        enemyCurrentHealth -= damage;
    }
}