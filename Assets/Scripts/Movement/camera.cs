using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public bool cameraActive = true; // set camera Script to true when menus aren't true.
    public enum RotationAxis
    {
        MouseX = 1, MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    // sets the maximum and minimum view angle in the y axis.
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    // sets the maximum and minimum view angle in the x axis.
    public float sensHorizontal = 10.0f;
    public float sensVertical = 10.0f;

    public float _rotationX = 0;

	// Update is called once per frame
	void Update () {
        if (cameraActive)
        {
            if (axes == RotationAxis.MouseX) // rotates in the x axis based on the mouse.
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
            }
            else if (axes == RotationAxis.MouseY) // rotates in the y axis based on the mouse
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
                _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); // Clamps the vertical angle within the min and max limits
            }
            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
	}
}
