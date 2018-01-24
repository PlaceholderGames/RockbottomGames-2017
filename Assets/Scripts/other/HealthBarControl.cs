using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarControl : MonoBehaviour
{
    private Slider healthBar;
    private int currentHealth = 100;
    
    void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
      
        healthBar.value = currentHealth;
    }

    public void changeHp(int Damage)
    {
        currentHealth -= Damage;
    }
}
