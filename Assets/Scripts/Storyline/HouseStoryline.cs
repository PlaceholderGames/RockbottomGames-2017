using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStoryline : MonoBehaviour {


    public GameObject Door;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject Bedroom1;
    public GameObject Bedroom2;
    public GameObject Bathroom;
    public GameObject houseMission;
    public GameObject pizzaMission;
    public GameObject tioletMission;
    public GameObject bedroomMission;
    public GameObject Pizza;

    float MessageTime = 15;
    float pizzaTime = 5;
    float bedroomTime = 5;

    public GameObject pizzaBox;
    public GameObject bedroom;
    bool pizzaFlag;
    bool bedroomFlag;


    private void Start()
    {
        pizzaFlag = false;
        bedroomFlag = false;
        Message1.SetActive(true);
        houseMission.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        MessageTime -= Time.deltaTime;
        if(MessageTime < 10 && MessageTime > 0)
        {
            Message1.SetActive(false);
            Message2.SetActive(true);
        }
        else if(MessageTime < 0)
        {
            Message1.SetActive(false);
            Message2.SetActive(false);
        }

        if(pizzaFlag)
        {
            pizzaTime -= Time.deltaTime;

            Pizza.SetActive(false);
            Bathroom.SetActive(true);
            pizzaMission.SetActive(false);
            tioletMission.SetActive(true);

            if(pizzaTime < 0)
            {
                Bathroom.SetActive(false);
                pizzaFlag = false;
            }
        }

        if(bedroomFlag)
        {
            bedroomTime -= Time.deltaTime;
            Bedroom2.SetActive(true);
            if(bedroomTime < 0)
            {
                Bedroom2.SetActive(false);
                bedroomFlag = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Door")
        {
            InputDetector.collide = true;
            if (Input.GetKeyDown("e"))
            {
                SetMessageFalse();
                Door.SetActive(true);
            }
        }
        if (other.tag == "Bedroom")
        {
            if (!bedroomFlag)
            {
                SetMessageFalse();
                Bedroom1.SetActive(true);
            }
        }
        if(other.tag == "Pizza")
        {
            InputDetector.collide = true;
            SetMessageFalse();

            Pizza.SetActive(true);
            houseMission.SetActive(false);
            pizzaMission.SetActive(true);

            if (Input.GetKeyDown("e"))
            {
                pizzaBox.tag = "Untagged";
                pizzaFlag = true;
            }
        }
        if (other.tag == "Toilet")
        {
            InputDetector.collide = true;
            if(Input.GetKeyDown("e"))
            {
                bedroomFlag = true;
                bedroom.tag = "Untagged";
            }
        }
        if (other.tag == "Bed")
        {
            InputDetector.collide = true;
            if(Input.GetKeyDown("e"))
            {
                InputDetector.pause = true;
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        InputDetector.collide = false;
        Door.SetActive(false);
        Bedroom1.SetActive(false);
        Bathroom.SetActive(false);
        Pizza.SetActive(false);
    }

    private void SetMessageFalse()
    {
        MessageTime = -1;
    }
}
