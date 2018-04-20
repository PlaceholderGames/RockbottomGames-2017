using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleportMaps : MonoBehaviour {

    public bool forest;
    public bool house;
    public GameObject panel;
	// Use this for initialization
	void Start () {
        forest = false;
        house = false;
	}

    void OnTriggerStay(Collider col)
    {
        Debug.Log(InputDetector.collide);
        if (col.tag == "Forest")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                forest = true;
                InputDetector.pause = true;
                panel.SetActive(true);
            }
        }
        else if (col.tag == "House")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                house = true;
                InputDetector.pause = true;
                panel.SetActive(true);
            }
        }
        else
        {
            panel.SetActive(false);
        }

    }
    void OnTriggerExit()
    {
        InputDetector.collide = false;
        forest = false;
        house = false;
    }

    public void setRoom()
    {
        if (forest)
        {
            SceneManager.LoadScene(2);
        }
        if(house)
        {
            SceneManager.LoadScene(3);
        }
    }
}
