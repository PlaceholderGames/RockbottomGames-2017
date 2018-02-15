using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage;
    public GameObject damageEffect;

	void Start ()
    {
		
	}
	

	void Update ()
    {

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().DamageEnemy(damage);
            GameObject effect = Instantiate(damageEffect, transform.position, transform.rotation);
            Destroy(effect , 0.5f);
            Destroy(gameObject);
        }
    }
}