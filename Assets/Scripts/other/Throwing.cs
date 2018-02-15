using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    public GameObject prefab;
    public Transform cameraPos;
    public Transform pause;

    private bool enter = false;

    private float delay = 1f;
    private float speed = 10f;
    private float spawn = 1f;
    private float force = 40f; 

    void Start () {
        //prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && pause.GetComponent<InputDetector>().pause == false)
        {
            if (enter == false)
            {
                GameObject projectile = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.Slerp(cameraPos.rotation, cameraPos.rotation, Time.time * speed)) as GameObject;
                projectile.transform.position = transform.position + cameraPos.transform.forward * spawn;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = cameraPos.transform.forward * force;
                StartCoroutine(timer());
            }
        }
	}
    IEnumerator timer()
    {
        enter = true;
        yield return new WaitForSecondsRealtime(delay);
        enter = false;
    }
}
