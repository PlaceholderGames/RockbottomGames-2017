using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interation : MonoBehaviour {

    public float range = 5f;
    public GameObject fPCamera;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Interact();
        } 
    }

    void Interact()
    {
       RaycastHit hit;
       if(Physics.Raycast(fPCamera.transform.position, fPCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }   
    }
}