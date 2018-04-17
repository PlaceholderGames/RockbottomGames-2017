using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public static bool pause;
    public static bool collide;
    public GameObject pauseMenu;
    public Transform cameraMove;
    public GameObject Interact;

    void Start()
    {
        pause = false;
        collide = false;
    }
    void Update()
    {
        if(collide == true)
        {
            Interact.SetActive(true);
        }
        else
        {
            Interact.SetActive(false);
        }

        if (Input.GetKeyDown("escape"))
        {
            pause = true;         
        }

        if (pause == true)
        {
            
            Time.timeScale = 0;
            cameraMove.GetComponent<camera>().cameraActive = false;
            GetComponent<camera>().cameraActive = false;
            if (Input.GetKeyDown("escape"))
            {
                pauseMenu.SetActive(true);
                Interact.SetActive(false);
            }
            else
            {
                Interact.SetActive(false);
            }
        }

        else if (pause == false)
        {
            Time.timeScale = 1;
            cameraMove.GetComponent<camera>().cameraActive = true;
            GetComponent<camera>().cameraActive = true;
            pauseMenu.SetActive(false);
        }
    }
}
