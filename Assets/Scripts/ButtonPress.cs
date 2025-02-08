using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Transform bridge;
    public float rotationSpeed;
    public float buttonSpeed = 1f;
    private bool isPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        isPressed = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isPressed = false;
    }



    void Update()
    {
        float angleZ;
        if (isPressed)
        {
            angleZ = 90f;
            transform.position = Vector3.Lerp(transform.position, new Vector3(167f, 19.8f, 168.1f), Time.deltaTime * buttonSpeed);
        }
        else
        {
            angleZ = 30f;
            transform.position = Vector3.Lerp(transform.position, new Vector3(167f, 20.236f, 168.1f), Time.deltaTime * buttonSpeed);
        }

        bridge.rotation = Quaternion.Lerp(bridge.rotation, Quaternion.Euler(0, 0, angleZ), Time.deltaTime * rotationSpeed);

    }
}
