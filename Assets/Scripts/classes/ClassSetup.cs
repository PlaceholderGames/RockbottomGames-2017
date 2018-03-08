using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        PlayerHealth.baseHealth = 10;
        PlayerHealth.characterHealth = 10;
  //      damage = 1;
    }

    public void SetMage()
    {
        PlayerHealth.baseHealth = 90;
        PlayerHealth.characterHealth = 90;
 //       damage = 15;
    }

    public void SetThief()
    {
        PlayerHealth.baseHealth = 100;
        PlayerHealth.characterHealth = 100;
 //       damage = 10;
    }

    public void SetWarrior()
    {
        PlayerHealth.baseHealth = 120;
        PlayerHealth.characterHealth = 120;
 //       damage = 5;
    }


}
