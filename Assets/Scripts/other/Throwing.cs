using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    private GameObject prefab;
    private GameObject WarriorWeapon;
    private GameObject ThiefWeapon;
    private GameObject MageWeapon;
    public GameObject Hatchet;
    public GameObject Dagger;
    public GameObject Fireball;

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
  
	// Update is called once per frame

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
                GameObject projectile = Instantiate(Hatchet, new Vector3(0, 0, 0), Quaternion.Slerp(cameraPos.rotation, cameraPos.rotation, Time.time * speed)) as GameObject;
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

    /* void weaponSelection()
       {
           WarriorWeapon = GameObject.FindGameObjectWithTag("Hatchet");


           if (classChecker.war_col == true)
           {
               WarriorWeapon.SetActive(true);
               prefab = Hatchet;
           }
           if (classChecker.thief_col == true)
           {

               prefab = Dagger;
           }
           if (classChecker.mage_col == true)
           {
               prefab = Fireball;
           }
       }
       */

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "WeaponsEnabled")
        {
           weaponEnabled = true;
        }
    }
}
