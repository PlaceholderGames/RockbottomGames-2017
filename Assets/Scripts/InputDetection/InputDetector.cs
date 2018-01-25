using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public bool pause;
    public Transform canvas;
    public Transform camera;

    // Update is called once per frame
    public void ResumeButton()
    {
        pause = !pause;
        Cursor.visible = !Cursor.visible;
    }
    void Start()
    {
        pause = false;
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pause = !pause;
            Cursor.visible = !Cursor.visible;
        }
        if (pause == false)
        {
            Time.timeScale = 1;
            canvas.gameObject.SetActive(false);
            camera.GetComponent<camera>().cameraActive = true;
            GetComponent<camera>().cameraActive = true;

        }
        else if (pause)
        {
            Time.timeScale = 0;
            canvas.gameObject.SetActive(true);
            camera.GetComponent<camera>().cameraActive = false;
            GetComponent<camera>().cameraActive = false;
        }
    }


}
