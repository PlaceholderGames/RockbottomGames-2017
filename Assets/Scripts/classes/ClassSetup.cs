using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : MonoBehaviour
{
    public GameObject Hatchet;
    public GameObject Dagger;
    public GameObject FireBall;
    


    // Use this for initialization
    void Start()
    {
        PlayerHealth.baseHealth = 10;
        PlayerHealth.characterHealth = 10;
    }

    public void SetMage()
    {
        PlayerHealth.baseHealth = 90;
        PlayerHealth.characterHealth = 90;
        Throwing.prefab = FireBall;
    }

    public void SetThief()
    {
        PlayerHealth.baseHealth = 100;
        PlayerHealth.characterHealth = 100;
        Throwing.prefab = Dagger;
    }

    public void SetWarrior()
    {
        PlayerHealth.baseHealth = 120;
        PlayerHealth.characterHealth = 120;
        Throwing.prefab = Hatchet;
    }


}
