using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDragonAttack : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
