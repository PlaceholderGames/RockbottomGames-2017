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
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().DamageEnemy(characterDamage);
            GameObject effect = Instantiate(damageEffect, transform.position, transform.rotation);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Dragon")
        {
            col.gameObject.GetComponent<DragonHealth>().DamageEnemy(characterDamage);
            GameObject effect = Instantiate(damageEffect, transform.position, transform.rotation);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
    }
}