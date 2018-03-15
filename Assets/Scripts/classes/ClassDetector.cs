using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassDetector : BaseCharacterClass
{
    public GameObject DeathMessage;
    public GameObject WarriorDescription;
    public GameObject ThiefDescription;
    public GameObject MageDescription;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Warrior")
        {
            WarriorDescription.SetActive(true);
        }
        if (col.tag == "Thief")
        {
            ThiefDescription.SetActive(true);
        }
        if (col.tag == "Mage")
        {
            MageDescription.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Warrior")
        {
            WarriorDescription.SetActive(false);
        }
        if (col.tag == "Thief")
        {
            ThiefDescription.SetActive(false);
        }
        if (col.tag == "Mage")
        {
            MageDescription.SetActive(false);
        }
    }
}