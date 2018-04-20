using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int playerBaseHealth;
    public static int characterHealth;

    public GameObject deathMessage;

    void Update()
    {

    }

    public void damageTaken(int enemyDamageAmount)
    {
        characterHealth = characterHealth - enemyDamageAmount; // deals the damage.

        //checks if play is dead.
        if (characterHealth <= 0)
        {
            characterHealth = 0;
            InputDetector.pause = true;
            deathMessage.SetActive(true);
        }
    }
}
