using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class Movement : MonoBehaviour {

    private float speed = 10.0f;
    private float walkSpeed = 10.0f;
    private float runSpeed = 25.0f;
    private float gravity = 10f;
    public float maxVelocityChange = 10.0f;
    float jumpHeight = 2.0f;
    public Rigidbody rb;
    public Boundary boundary;

    bool jump = true;
    bool grounded = false;

    // Use this for initialization
    void Start () {
        //charCont = GetComponent<CharacterController>();
	}

    void Awake()
    {
        rb.freezeRotation = true;
        rb.useGravity = false;
    }

    // Update 
    void FixedUpdate ()
    {   
        if (grounded)
        {
            Vector3 velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            velocity = transform.TransformDirection(velocity);
            velocity *= speed;

            sprint();

            Vector3 vel = rb.velocity;
            Vector3 velChange = (velocity - vel);
            velChange.x = Mathf.Clamp(velChange.x, -maxVelocityChange, maxVelocityChange);
            velChange.z = Mathf.Clamp(velChange.z, -maxVelocityChange, maxVelocityChange);
            velChange.y = 0;
            rb.AddForce(velChange, ForceMode.VelocityChange);

            if (jump && Input.GetButton("Jump"))
            {
                rb.velocity = new Vector3(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
            }
        }

        rb.AddForce(new Vector3(0, -gravity * rb.mass, 0));

        grounded = false;
    }

    void sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed; // sets the speed to a run.
        else
            speed = walkSpeed; // set it back to a walk.
    }

    void OnCollisionStay()
    {
        grounded = true;
    }

    float CalculateJumpVerticalSpeed()
    {
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }
}
