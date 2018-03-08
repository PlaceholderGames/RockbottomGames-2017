using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarControl : MonoBehaviour
{
    public Slider healthBar;

    void Awake()
    {
        healthBar.maxValue = PlayerHealth.baseHealth;   
        healthBar.value = PlayerHealth.characterHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = PlayerHealth.baseHealth;
        healthBar.value = PlayerHealth.characterHealth;
    }


}

