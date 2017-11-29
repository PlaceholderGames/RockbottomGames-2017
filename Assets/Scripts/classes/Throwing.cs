using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    public GameObject prefab;
    public Transform cameraPos;
    float spawn = 1f;
    float force = 20f; 
    void Start () {
        //prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + cameraPos.transform.forward * spawn;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = cameraPos.transform.forward * force;
        }
	}
}
