using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;


    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public bool isActive;

    // public GameObject Player;

    Rigidbody rb;
    public GameObject Player;

    //Moving the doors
    Transform tfDoors;
    public GameObject Doors;


    // Use this for initialization
    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();     //Gets players rigidbody
        tfDoors = Doors.GetComponent<Transform>();

        /////////////////////////////////////////////
        //First Load

        MakeKinemtic();
    
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        

        if (endAtLine == 0)      //if set to 0 then read all not nothing.
        {
            endAtLine = textLines.Length - 1;
        }

        if (isActive)
        {
            EnableTextBox();
        }
        else
            DisableTextBox();

    }

    // Update is called once per frame
    void Update()
    {
        theText.text = textLines[currentLine];

       
        if(!isActive)        //if text is not active then dont run.
        {
            return;
        }
        

        if (Input.GetKeyDown(KeyCode.Return))        //Press enter to navigate, 
        {                                           //throught the text.
            currentLine += 1;
        }

        if (currentLine > endAtLine)
        {
            DisableTextBox();   //Stops at the current set endline
        }


        if(currentLine == 17)       //Allows the player to move out of the tut.
        {
            Disableinemtic();
        }

        if(currentLine == 33)
        {
            Debug.Log("Line28");
            tfDoors.position = new Vector3(0.0f, 8f, 0.0f);
           
        }

    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
    }

    public void MakeKinemtic()
    {
        Debug.Log("Make");
        rb.isKinematic = true;
    }

    public void Disableinemtic()
    {
        rb.isKinematic = false;
    }

    public void ReloadScript(TextAsset theText)
    {
        if(theText !=null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));

        }
    }
}
