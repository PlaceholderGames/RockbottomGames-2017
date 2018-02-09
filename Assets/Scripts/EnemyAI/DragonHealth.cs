using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : MonoBehaviour {

    private bool enter = false;
    private float delay = 0.2f;
    private int dragonHealth;
    private HealthBarControl healthBar;
    public int enemyDamage;
    public bool takeDamage = false;

    void Start()
    {
        dragonHealth = 100;
        enemyDamage = 10;

    }

    void Awake()
    {
        healthBar = GameObject.Find("DragonHealthBar").GetComponent<HealthBarControl>();
    }

    void Update()
    {   //checks if play is dead.
        if (dragonHealth <= 0)
        {
            
        }

        if (takeDamage == true) //checks if damage bool is active. 
        {
            if (enter == false) //check is the time delay is deactivated.
            {
                dragonHealth = dragonHealth - enemyDamage; // dealts the damage.
                healthBar.changeHp(enemyDamage); //cheack the Ui health bar to reflect the damage taken. 
                StartCoroutine(timer()); // starts the timer
                takeDamage = false;// sets the damage bool to false. ready for next damage.
            }
        }

    }
    //Timer to give a grace period for the damage. 
    IEnumerator timer()
    {
        enter = true;
        yield return new WaitForSeconds(delay);
        enter = false;
    }

    //Detects the collision.
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "enemyAttack")
        {
            takeDamage = true;
        }
    }
}

