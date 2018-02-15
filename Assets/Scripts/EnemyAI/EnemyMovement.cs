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
    public Vector3 defaultPosition;

	void Start()
    {
        agent = transform.parent.GetComponent<NavMeshAgent>();
        defaultPosition = transform.position;
	}
	
	void Update()
    {
        if (aggro == true)
        {
            agent.SetDestination(target.position);
            Debug.Log("Aggro = True");
        }
        else
        {
            agent.SetDestination(defaultPosition);
            Debug.Log("Aggro = False");
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
