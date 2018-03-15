using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDeadMessage : MonoBehaviour {
    public GameObject MessageBox;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //camera
        MessageBox.SetActive(true);
    }
}
