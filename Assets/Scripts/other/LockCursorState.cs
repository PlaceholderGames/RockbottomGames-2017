using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursorState : MonoBehaviour {

    CursorLockMode wantedMode; // Cotains cursor mode.
  
    void Awake() // Activate at the beginning of runtime.
    {
        setCursorState(); // call the setCursorState Function.
    }

    void setCursorState()
    {
        Cursor.lockState = wantedMode = CursorLockMode.Locked; // sets the cursors lockstate to locked.
        // Hide cursor when locking
        Cursor.visible = false;
    }

    void OnGUI()
    {
        // Release cursor on escape keypress.
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.E) || PlayerHealth.characterHealth <= 0)
        {
            Cursor.lockState = wantedMode = CursorLockMode.None; // sets cursor to unlocked.
            Cursor.visible = true; // set the cursor to visible.
        }
    }

    public void OnResume() // Onclick event that can be used on a button to lock the cursor.
    {
       setCursorState(); // call the setCursorState Function. 
    }
}
