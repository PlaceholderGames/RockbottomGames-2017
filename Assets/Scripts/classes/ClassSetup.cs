using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : MonoBehaviour
{
    void Start()
    {
        PlayerHealth.playerBaseHealth = 10;
        PlayerHealth.characterHealth = 10;

        BaseCharacterClass.characterDamage = 1;
    }

    public void SetMage()
    {
        PlayerHealth.playerBaseHealth = 50;
        PlayerHealth.characterHealth = 50;

        BaseCharacterClass.characterDamage = 15;
    }

    public void SetThief()
    {
        PlayerHealth.playerBaseHealth = 100;
        PlayerHealth.characterHealth = 100;

        BaseCharacterClass.characterDamage = 10f;
    }

    public void SetWarrior()
    {
        PlayerHealth.playerBaseHealth = 150;
        PlayerHealth.characterHealth = 150;

        BaseCharacterClass.characterDamage = 7.5f;
    }

    public void DestroyClasses()
    {
        Destroy(GameObject.FindWithTag("Warrior"));
        Destroy(GameObject.FindWithTag("Mage"));
        Destroy(GameObject.FindWithTag("Thief"));
    }
}
