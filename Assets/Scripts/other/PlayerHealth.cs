using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private bool enter = false;
    private float delay = 0.2f;
    private HealthBarControl healthBar;
    public Transform char_health;
    public int characterHealth;
    protected static int characterDamage;
    protected int enemyDamage;
    protected bool takeDamage;

    public GameObject deathMessage;

    void Start ()
    {
        GameObject thePlayer = GameObject.Find("ThePlayer");
        ClassSetup playerClass = thePlayer.GetComponent<ClassSetup>();   
        characterHealth = playerClass.health; 
        characterDamage = 1;
        enemyDamage = 10;
    }

    void Awake()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarControl>();
    }

	void Update ()     
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

    public void SetHealth()
    {
        characterHealth = characterHealth;
    }
}
