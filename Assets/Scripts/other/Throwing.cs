using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    public static GameObject prefab;

    public Transform cameraPos;
    public Transform weapon;
    public Transform pause;

    private bool enter = false;
    private bool weaponEnabled;

    private float delay = 1f;
    private float speed = 10f;
    private float spawn = 1f;
    private float force = 40f;

    private bool axeCooldown = false;
    private const int MAX_VALUE = 5;

    InputDetector classChecker;

    void Awake()
    {
        weaponEnabled = true;
    }

	void Update ()
    {
        if (axeCooldown == false)
        {
            throwing();
        }
        tick();
	}

    void throwing()
    {
        if (Input.GetMouseButtonDown(0) && InputDetector.pause == false)
        {
            if (enter == false)
             {   
                GameObject projectile = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.Slerp(cameraPos.rotation, cameraPos.rotation, Time.time * speed)) as GameObject;
                projectile.transform.position = weapon.transform.position + cameraPos.transform.forward;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = cameraPos.transform.forward * force;
                Destroy(projectile, 2f);
             }
        }
    }

    void tick()
    {
        if (GameObject.FindGameObjectsWithTag("Hatchet").Length >= MAX_VALUE || GameObject.FindGameObjectsWithTag("Dagger").Length >= MAX_VALUE)
        {
            axeCooldown = true;
        }
        else
        {
            axeCooldown = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "WeaponsEnabled")
        {
           weaponEnabled = true;
        }
    }
}
