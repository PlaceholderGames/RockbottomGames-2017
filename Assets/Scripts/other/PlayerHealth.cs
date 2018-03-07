﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : BaseCharacterClass
{
    private bool enter = false;
    private float delay = 0.2f;
    private HealthBarControl healthBar;
    public GameObject deathWindow;
    public Transform cameraMove;

    void Start ()
    {
        characterHealth = 100;
        characterDamage = 1;
        enemyDamage = 10;

    }

    void Awake()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarControl>();
    }

	void Update ()
    {   //checks if play is dead.
		if (characterHealth <= 0)
        {
            cameraMove.GetComponent<camera>().cameraActive = false;
            Cursor.visible = true;
            deathWindow.SetActive(true);
        }

        if (takeDamage == true) //checks if damage bool is active. 
        {
            if (enter == false) //check is the time delay is deactivated.
            {
                characterHealth = characterHealth - enemyDamage; // dealts the damage.
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
