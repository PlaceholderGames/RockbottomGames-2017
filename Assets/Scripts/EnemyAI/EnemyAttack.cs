using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : BaseCharacterClass
{
    private float villagerAttackSpeed = 0.25f;
    private float timer = 5f;
    public GameObject player;

    void Update ()
    {
        timer += Time.deltaTime;
        if (attack == true && timer >= villagerAttackSpeed)
        {
            PlayerHealth.characterHealth = PlayerHealth.characterHealth - villagerDamage;
            timer = 0f;
        }
        if (PlayerHealth.characterHealth <= 0)
        {
            attack = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            attack = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            attack = false;
        }
    }
}