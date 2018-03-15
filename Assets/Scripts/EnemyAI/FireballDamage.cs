using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDamage : BaseCharacterClass
{
    public GameObject player;

    void Update ()
    {
        if (attack == true)
        {
           PlayerHealth.characterHealth =PlayerHealth.characterHealth - fireballDamage;
            attack = false;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("attack");
            attack = true;
          //  Destroy(gameObject);
        }
    }
    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        Debug.Log("Exit");
    //        attack = false;
    //    }
    //}
}
