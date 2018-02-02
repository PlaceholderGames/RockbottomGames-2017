using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public bool pause;
    public bool collide;
    public GameObject canvas;
    public Transform cameraMove;
    public GameObject WarriorDescription;
    public GameObject ThiefDescription;
    public GameObject MageDescription;
    bool war_col, thief_col, mage_col;

    void Start()
    {
        pause = false;
        collide = false;
        war_col = false;
        thief_col = false;
        mage_col = false;
    }
    void Update()
    {
        if ((Input.GetKeyDown("escape")) || (Input.GetKeyDown("e") && collide == true))
        {
            pause = true;
            Cursor.visible = true;
        }

        if (pause == true)
        {
            Time.timeScale = 0;
            cameraMove.GetComponent<camera>().cameraActive = false;
            GetComponent<camera>().cameraActive = false;
            if (Input.GetKeyDown("escape"))
            {
                canvas.SetActive(true);
            }
            else
            {
                if (war_col)
                {
                    WarriorDescription.SetActive(true);
                    war_col = false;
                }
                if (thief_col)
                {
                    ThiefDescription.SetActive(true);
                    thief_col = false;
                }
                if (mage_col)
                {
                    MageDescription.SetActive(true);
                    mage_col = false;
                }
            }
        }

        else if (pause == false)
        {
            Time.timeScale = 1;
            canvas.SetActive(false);
            cameraMove.GetComponent<camera>().cameraActive = true;
            GetComponent<camera>().cameraActive = true;

        }

    }


    void OnTriggerEnter(Collider col)
    {
        collide = true;
        if (col.tag == "Warrior")
        {
            war_col = true;
        }
        else if (col.tag == "Thief")
        {
            thief_col = true;
        }
        else if (col.tag == "Mage")
        {
            mage_col = true;
        }
        else
        {
            collide = false;
        }
    }

    public void ResumeButton()
    {
        pause = false;
        Cursor.visible = false;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }

}
