using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float speed = 10.0f;
    private float walkSpeed = 10.0f;
    private float runSpeed = 25.0f;
    private float gravity = 10f;
    private CharacterController charCont;

    // Use this for initialization
    void Start () {
        charCont = GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void Update ()
    {   
        // set the movement for the character.
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed); //Limits the max speed of the player

        movement.y -= gravity;

        movement *= Time.deltaTime; //Ensures the speed the player moves doesn't change based on the frame rate
        movement = transform.TransformDirection(movement);
        charCont.Move(movement);
        sprint(); // actives the sprint function. 
	}
    void sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed; // sets the speed to a run.
        else
            speed = walkSpeed; // set it back to a walk.
    }
}
