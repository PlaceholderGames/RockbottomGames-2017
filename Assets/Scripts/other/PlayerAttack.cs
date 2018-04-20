using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : BaseCharacterClass
{
    // Used on Hatchet
    public GameObject damageEffect;

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = col.transform;

            col.gameObject.GetComponent<EnemyHealth>().DamageEnemy();
            GameObject effect = Instantiate(damageEffect, transform.position, transform.rotation);
            Destroy(effect, 0.5f);
            Destroy(gameObject, 3f);
        }
        if (col.tag == "Dragon")
        {
            col.gameObject.GetComponent<DragonHealth>().DamageEnemy();
            GameObject effect = Instantiate(damageEffect, transform.position, transform.rotation);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
        if (col.tag == "Terrain")
        {
            GetComponent<Rigidbody>().isKinematic = true;   //Freezes item when hitting terrain
            Destroy(gameObject, 3f);
        }
        if (col.gameObject.tag == "Fireball")
        {
            Destroy(gameObject);
        }
    }
}