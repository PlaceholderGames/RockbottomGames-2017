using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitCameraChange : MonoBehaviour {

    /// <Camera>
    public Camera PlayerCamera;
    public Camera PitCamera;
    public bool cam2;


    // Use this for initialization
    void Start () {

       PlayerCamera.gameObject.SetActive(true);
       PitCamera.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if(cam2)
        {
            PlayerCamera.gameObject.SetActive(false);
            PitCamera.gameObject.SetActive(true);
        }
		
	}


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            cam2 = true;
        }
    }
}
