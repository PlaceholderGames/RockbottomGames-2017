using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour
{
    public int characterHealth;
    public int baseHealth;
    protected int characterDamage;
    protected int enemyDamage;
    protected bool takeDamage;

    public GameObject deathMessage;
}