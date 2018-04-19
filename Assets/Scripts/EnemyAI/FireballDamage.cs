using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDamage : BaseCharacterClass
{
    bool damageDone = false;

    void Update ()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (damageDone == false)
            {
                damageDone = true;
                col.GetComponent<PlayerHealth>().damageTaken(fireballDamage);
                Destroy(gameObject);
            }          
        }

        if (col.gameObject.tag == "Terrain")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Dagger")
        {
            Destroy(gameObject);
        }
    }
}
