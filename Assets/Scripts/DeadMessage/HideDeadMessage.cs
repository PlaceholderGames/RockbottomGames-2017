using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDeadMessage : MonoBehaviour {
    public GameObject DeadMessageBox;
	// Use this for initialization
	void Start () {
        DeadMessageBox.SetActive(false);
	}

}
