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
    public GameObject Mission1;
    public GameObject Mission2;
    float MessageTime = 15;

    public bool enter;

    private void Start()
    {
        enter = false;
        Message1.SetActive(true);
        Mission1.SetActive(true);
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
        else if (other.tag == "Bedroom")
        {
            SetMessageFalse();
            Bedroom1.SetActive(true);
        }
        else if(other.tag == "Bathroom")
        {
            SetMessageFalse();
            Bathroom.SetActive(true);
            Mission1.SetActive(false);
            Mission2.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        Door.SetActive(false);
        Bedroom1.SetActive(false);
    }

    private void SetMessageFalse()
    {
        MessageTime = -1;
    }
}
