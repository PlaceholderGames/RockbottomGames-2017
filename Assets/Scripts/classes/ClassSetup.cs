using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        PlayerHealth.playerBaseHealth = 100;
        PlayerHealth.characterHealth = 100;
    }

    public void SetMage()
    {
        PlayerHealth.playerBaseHealth = 90;
        PlayerHealth.characterHealth = 90;
    }

    public void SetThief()
    {
        PlayerHealth.playerBaseHealth = 100;
        PlayerHealth.characterHealth = 100;
    }

    public void SetWarrior()
    {
        PlayerHealth.playerBaseHealth = 120;
        PlayerHealth.characterHealth = 120;
    }
}
