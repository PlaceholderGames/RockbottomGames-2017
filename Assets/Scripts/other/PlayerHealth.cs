using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int baseHealth;
    public static int characterHealth;
    protected int characterDamage;

    public GameObject deathMessage;

    void Update()
    {
        Debug.Log(characterHealth);
    }

    public void damageTaken(int enemyDamageAmount)
    {
        characterHealth = characterHealth - enemyDamageAmount; // dealts the damage.
        
        //checks if play is dead.
        if (characterHealth <= 0)
        {
            characterHealth = 0;
            InputDetector.pause = true;
            deathMessage.SetActive(true);
        }
    }
}
