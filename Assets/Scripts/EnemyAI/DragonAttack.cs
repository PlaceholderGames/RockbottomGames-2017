using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAttack : BaseCharacterClass
{
    public GameObject player;
    public float timeBetweenAttacks = 1f;
    public Vector3 playerDirection = Vector3.zero;
    public RaycastHit lastPos;
    private float viewRange = 100f;
    private float rayRange = 60f;
    private float timer = 5f;

    //Fireball
    public GameObject fireballPrefab;
    public float force = 60f;
    
    Rigidbody fireballRB;


    // Use this for initialization
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        //timer//
        timer += Time.deltaTime;
        playerDirection = (player.transform.position - transform.position); //Distance between Dragon and player

        if (playerDirection.magnitude < viewRange && timer >= timeBetweenAttacks)
        {
            if (Physics.Raycast(transform.position, playerDirection, out lastPos, rayRange))
            {
                if (lastPos.collider.tag == "Player")
                {              
                    Attack();
                }
            }
        }
    }

    void Attack()
    {
        //Attack Function
        timer = 0f;     //resets timer.
        transform.LookAt(lastPos.transform.position);
        if (characterHealth > 0)
        {
            GameObject fireballInstance = Instantiate(fireballPrefab) as GameObject;
            fireballInstance.transform.position = transform.position;
            Rigidbody rb = fireballInstance.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * force;          
        }
    }
}