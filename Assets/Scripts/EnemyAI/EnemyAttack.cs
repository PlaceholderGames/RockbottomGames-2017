using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : BaseCharacterClass
{
    private float villagerAttackSpeed = 0.25f;
    private float timer = 5f;
    public GameObject player;
    bool playerInRange = false;

    void Update ()
    {
        timer += Time.deltaTime;
        if (playerInRange == true && timer >= villagerAttackSpeed)
        {
            player.GetComponent<PlayerHealth>().damageTaken(villagerDamage);
            timer = 0f;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            playerInRange = false;
        }
    }
}