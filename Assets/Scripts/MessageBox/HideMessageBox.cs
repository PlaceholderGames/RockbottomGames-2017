using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMessageBox : MonoBehaviour {
    public GameObject MessageBox;
	// Use this for initialization
	void Start () {
        MessageBox.SetActive(false);
	}
	

}
