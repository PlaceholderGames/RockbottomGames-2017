using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : BaseCharacterClass
{
    // Use this for initialization
    void Start()
    {
        baseHealth = 10;
        characterHealth = 10;
    }

    public void SetMage()
    {
        baseHealth = 90;
        characterHealth = 90;
    }

    public void SetThief()
    {
        baseHealth = 100;
        characterHealth = 100;
    }

    public void SetWarrior()
    {
        baseHealth = 120;
        characterHealth = 120;
    }
}
