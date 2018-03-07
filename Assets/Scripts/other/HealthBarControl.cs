using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarControl : MonoBehaviour
{
    public Transform char_health;
    private Slider healthBar;
    public int currentHealth;

    GameObject thePlayer = GameObject.Find("ThePlayer");
    ClassSetup playerClass = thePlayer.GetComponent<ClassSetup>();

    void Awake()
    {
        healthBar = GetComponent<Slider>();
        currentHealth = ClassSetup.health;
        healthBar.maxValue = currentHealth;
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
