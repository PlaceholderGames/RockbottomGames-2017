using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour
{
    protected int characterHealth;
    protected int characterDamage;
    protected int enemyDamage;
    protected bool takeDamage;

    public GameObject deathMessage;
}