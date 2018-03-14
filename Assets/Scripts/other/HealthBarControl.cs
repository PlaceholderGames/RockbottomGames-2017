using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarControl : BaseCharacterClass
{
    public Slider healthBar;

    void Awake()
    {
        healthBar.maxValue = baseHealth;   
        healthBar.value = characterHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = baseHealth;
        healthBar.value = characterHealth;
    }


}

