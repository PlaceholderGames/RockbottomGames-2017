using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSelection : MonoBehaviour
{

    public GameObject WarriorDescription;
    public GameObject ThiefDescription;
    public GameObject MageDescription;
    public GameObject NPC;

    // Use this for initialization
    void Start()
    {
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Warrior")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                InputDetector.pause = true;
                WarriorDescription.SetActive(true);
            }
        }
        else if (col.tag == "Thief")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                InputDetector.pause = true;
                ThiefDescription.SetActive(true);
            }
        }
        else if (col.tag == "Mage")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                InputDetector.pause = true;
                MageDescription.SetActive(true);
            }
        }
        else if (col.tag == "NPC")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                InputDetector.pause = true;
                NPC.SetActive(true);
            }
        }

    }
    void OnTriggerExit()
    {
        InputDetector.collide = false;
    }
}


