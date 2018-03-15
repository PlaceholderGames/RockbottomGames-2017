using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public bool enter = false;
    private float delay = 0.2f;
    public static int baseHealth;
    public static int characterHealth;
    protected int characterDamage;
    protected int enemyDamage;
    public bool takeDamage;

    public GameObject deathMessage;

    private void Start()
    {
        enemyDamage = 10;
    }
    void Update()
    {
        Debug.Log(characterHealth);
        //checks if play is dead.
        if (characterHealth <= 0)
        {
            deathMessage.SetActive(true);
        }
        if (takeDamage == true) //checks if damage bool is active. 
        {
            if (enter == false) //check is the time delay is deactivated.
            {
                characterHealth = characterHealth - enemyDamage; // dealts the damage.
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
