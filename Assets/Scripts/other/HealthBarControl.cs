using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarControl : MonoBehaviour
{
    public Slider playerHealthBar;
    public Slider dragonHealthBar;

    void Awake()
    {
        playerHealthBar.maxValue = PlayerHealth.playerBaseHealth;
        playerHealthBar.value = PlayerHealth.characterHealth;

        dragonHealthBar.maxValue = BaseCharacterClass.dragonHealth;
        dragonHealthBar.value = DragonHealth.dragonCurrentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthBar.maxValue = PlayerHealth.playerBaseHealth;
        playerHealthBar.value = PlayerHealth.characterHealth;

        dragonHealthBar.maxValue = DragonHealth.dragonHealth;
        dragonHealthBar.value = DragonHealth.dragonCurrentHealth;

        if (DragonHealth.dragonCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

