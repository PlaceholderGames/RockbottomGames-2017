using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public Transform self;
    NavMeshAgent agent;
    bool aggro = false;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        if (aggro == true)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.SetDestination(self.position);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            aggro = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            aggro = false;
        }
    }
}
