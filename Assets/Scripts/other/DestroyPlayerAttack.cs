using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayerAttack : MonoBehaviour {
    //Destroys GameObjects when interacting with this Tag.
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Destroyer" || col.gameObject.tag == "Dragon")
        {
            Destroy(gameObject);
        }
    }
}
