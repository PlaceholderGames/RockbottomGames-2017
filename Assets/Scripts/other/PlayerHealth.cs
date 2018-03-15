using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : BaseCharacterClass
{
    public bool enter = false;
    private float delay = 0.2f;
    private HealthBarControl healthBar;
    public GameObject deathWindow;
    public Transform cameraMove;

    void Awake()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarControl>();
    }

    void Update()
    {
        //checks if play is dead.
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
                StartCoroutine(timer());
                characterHealth = characterHealth - enemyDamage;
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
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "enemyAttack")
        {
            takeDamage = false;
        }
    }
}
