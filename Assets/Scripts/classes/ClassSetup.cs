using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSetup : MonoBehaviour
{
    public int health = 10;
    public static int damage;
    // Use this for initialization
    void Start()
    {
        health = 10;
        damage = 1;
    }

    public void SetMage()
    {
        health = 90;
        damage = 15;
    }

    public void SetThief()
    {
        health = 100;
        damage = 10;
    }

    public void SetWarrior()
    {
        health = 120;
        damage = 5;
    }


}
