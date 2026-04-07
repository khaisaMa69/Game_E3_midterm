using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed settings
    public float maxForwardSpeed = 20.0f;
    public float maxRotationSpeed = 50.0f;
    public string forwardAxis;
    public string lateralAxis;

    public Camera thirdPersonCamera;
    public Camera driverCamera;
    public KeyCode switchCameraKey;

    // Start is called before the first frame update
    void Start()
    {
        thirdPersonCamera.enabled = true;
        driverCamera.enabled = false;
    }

    // Update is called once per frame (before LateUpdate that we user for the camera)
    void Update()
    {
        float forwardInput = Input.GetAxis(forwardAxis);
        float lateralInput = Input.GetAxis(lateralAxis);

        float forwardSpeed = forwardInput * maxForwardSpeed;
        float rotationSpeed = lateralInput * maxRotationSpeed * forwardInput;

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);

        if (Input.GetKeyDown(switchCameraKey))
        {
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
            driverCamera.enabled = !driverCamera.enabled;
        }
    }
}
