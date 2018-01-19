using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    public GameObject prefab;
    public Transform Weapon;
    public Transform cameraPos;
    private float delay = 1.0f;
    private bool enter = false;
    float spawn = 1.0f;
    float force = 20f;

    void Start () {
        //prefab = Resources.Load("projectile") as GameObject;
       
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            
            if (enter == false)
            {
                GameObject projectile = Instantiate(prefab) as GameObject;
                projectile.transform.position = Weapon.position + Weapon.transform.forward * spawn;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = cameraPos.transform.forward * force;
                StartCoroutine(timer());
               
            }
            

        }
	}

    IEnumerator timer()
    {
        enter = true;
        yield return new WaitForSeconds(delay);
        enter = false;
    }
    
    public void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
        }
    }
}
