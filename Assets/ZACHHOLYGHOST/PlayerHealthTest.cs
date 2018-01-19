using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthTest : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;
    private bool isDead;

    bool playerHit = false;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerHit == true)
        {
           // Destroy(gameObject);
            currentHealth -= 10;
            if (currentHealth <= 0 && !isDead)
            {
                Death();
             
            }
            playerHit = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Fireball")
        {
            playerHit = true;
        }
    }

    void Death()
    {
        isDead = true;




    }
}
