using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    private GameObject prefab;
    public GameObject WarriorWeapon;
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

    InputDetector classChecker;

    void Awake()
    {
        weaponEnabled = false;
    }
  
	// Update is called once per frame

	void Update ()
    {
        if (weaponEnabled == true)

        {
            if (Input.GetMouseButtonDown(0) && pause.GetComponent<InputDetector>().pause == false)
            {
                throwing();
                weaponSelection();
            }
        }
	}

    void throwing()
    {
        if (enter == false)
        {
            GameObject projectile = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.Slerp(cameraPos.rotation, cameraPos.rotation, Time.time * speed)) as GameObject;
            projectile.transform.position = weapon.transform.position + cameraPos.transform.forward;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = cameraPos.transform.forward * force;
            StartCoroutine(timer());
        }
    }

    void weaponSelection()
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
    IEnumerator timer()
    {
        enter = true;
        yield return new WaitForSecondsRealtime(delay);
        enter = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "WeaponsEnabled")
        {
           weaponEnabled = true;
        }
    }
}
