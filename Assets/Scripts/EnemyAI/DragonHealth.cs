using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : BaseCharacterClass
{
   // private bool enter = false;
   // private float delay = 0.2f;
    private int dragonCurrentHealth;
    //private HealthBarControl healthBar;

    public GameObject winMessage;

    void Start()
    {
        dragonCurrentHealth = dragonHealth;
    }

    //void Awake()
    //{
    //    healthBar = GameObject.Find("Dragon Health Bar").GetComponent<HealthBarControl>();
    //}

    void Update()
    {   //checks if play is dead.
        if (dragonCurrentHealth <= 0)
        {
            Destroy(gameObject);
            InputDetector.pause = true;
            winMessage.SetActive(true);
        }

        //////////if (takeDamage == true) //checks if damage bool is active. 
        //////////{
        //////////    if (enter == false) //check is the time delay is deactivated.
        //////////    {
        //////////        dragonCurrentHealth = dragonCurrentHealth - enemyDamage; // dealts the damage.
        //////////        healthBar.changeHp(enemyDamage); //cheack the Ui health bar to reflect the damage taken. 
        //////////        StartCoroutine(timer()); // starts the timer
        //////////        takeDamage = false;// sets the damage bool to false. ready for next damage.
        //////////    }
        //////////}

    }
    //Timer to give a grace period for the damage. 
    //IEnumerator timer()
    //{
    //    enter = true;
    //    yield return new WaitForSeconds(delay);
    //    enter = false;
    //}

    ////Detects the collision.
    //void OnTriggerEnter(Collider col)
    //{
    //    if (col.tag == "enemyAttack")
    //    {
    //        takeDamage = true;
    //    }
    //}

    public void DamageEnemy(int damage)
    {
        dragonCurrentHealth -= damage;
    }
}

