using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : BaseCharacterClass
{
    private bool enter = false;
    private HealthBarControl healthBar;
    private bool NPCdamage = false;
    public float timeBetweenAttacks = 0.1f;

    //NPC timer;
    private float timer = 5f;


    void Start ()
    {
        characterHealth = 100;
        characterDamage = 1;
        enemyDamage = 10;
        fireballDamage = 15;
    }

    void Awake()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarControl>();
    }

	void Update ()
    {   //checks if play is dead.
		if (characterHealth <= 0)
        {
            deathMessage.SetActive(true);
        }
        timer += Time.deltaTime;

        if (takeDamage == true) //checks if damage bool is active. 
        {
            if (enter == false) //check is the time delay is deactivated.
            {
                characterHealth = characterHealth - enemyDamage; // dealts the damage.
                healthBar.changeHp(enemyDamage); //cheack the Ui health bar to reflect the damage taken. 
                takeDamage = false;// sets the damage bool to false. ready for next damage.
            }
        }
        else if(NPCdamage == true && timer >= timeBetweenAttacks)
        {          
           characterHealth = characterHealth - enemyDamage; // dealts the damage.
           healthBar.changeHp(enemyDamage); //cheack the Ui health bar to reflect the damage taken. 
           timer = 0f;
        }
    }
  
    //Detects the collision.
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Fireball")
        {
            takeDamage = true; 
        }
        else if (col.tag == "enemyAttack")
            {
            NPCdamage = true;
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.tag == "enemyAttack")
        {
            NPCdamage = false;
        }
    }
}