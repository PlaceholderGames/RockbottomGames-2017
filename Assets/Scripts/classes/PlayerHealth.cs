using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : BaseCharacterClass
{
    private bool enter = false;
    private float delay = 0.2f;
    private HealthBarControl healthBar;

    void Start()
    {
        characterHealth = 100;
        characterDamage = 1;
        enemyDamage = 10;

    }

    void Awake()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarControl>();
    }

    void Update()
    {
        if (characterHealth <= 0)
        {
            deathMessage.SetActive(true);
        }

        if (takeDamage == true)
        {
            if (enter == false)
            {
                StartCoroutine(timer());
                characterHealth = characterHealth - enemyDamage;
                healthBar.changeHp(enemyDamage);
            }
        }

    }

    IEnumerator timer()
    {
        enter = true;
        yield return new WaitForSeconds(delay);
        enter = false;
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "enemyAttack")
        {
            takeDamage = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "enemyAttack")
        {
            takeDamage = false;
        }
    }
}

