using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour
{
    public int characterHealth =100;
    protected int characterDamage;
    protected int enemyDamage;
    protected int fireballDamage;
    protected bool takeDamage;

    public GameObject deathMessage;
}