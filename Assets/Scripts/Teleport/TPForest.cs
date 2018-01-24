using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPForest : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Forest")
        {
            SceneManager.LoadScene("ForestScene_2.2");
        }
    }
}
