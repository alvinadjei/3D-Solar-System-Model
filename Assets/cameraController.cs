using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 100f;
    public Vector3 startingPosition;
    public Vector3 startingRotationAngles = new Vector3(0f, 45f, 0f);


    void Start()
    {
        // lock cursror in center of screen 
        Cursor.lockState = CursorLockMode.Locked;

        // Set camera initial values
        transform.position = startingPosition;

        Quaternion startingRotation = Quaternion.Euler(startingRotationAngles);
        transform.rotation = startingRotation;
    }

    void Update()
    {
        Cursor.visible = true;

        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float upInput = Input.GetKey(KeyCode.Space) ? 1f : 0f;
        float downInput = Input.GetKey(KeyCode.LeftShift) ? -1f : 0f;

        Vector3 moveDirection = (transform.right * horizontalInput + transform.forward * verticalInput + transform.up * (upInput + downInput)).normalized;
        transform.position += moveDirection * movementSpeed * Time.deltaTime;

        // Rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.left * mouseY * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
