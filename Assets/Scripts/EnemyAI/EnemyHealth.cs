using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth;
    public int enemyCurrentHealth;

    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }


    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            Debug.Log("Enemy dead");
            Destroy(gameObject);
        }
    }

    public void DamageEnemy (int damage)
    {
        enemyCurrentHealth -= damage;
    }

    public void SetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }
}