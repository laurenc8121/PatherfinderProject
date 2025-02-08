using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); ;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        moveDirection = new Vector3(-moveX, 0, moveZ);
        moveDog();
    }

    void FixedUpdate()
    {
        float yCoordinate = 21.821f;
        Vector3 position = rb.position;

        if (position.y > yCoordinate)
        {
            position.y = yCoordinate;
            rb.position = position;
        }

    }

    private void moveDog()
    {
        if (moveDirection.magnitude > 0.1f)
        {
            rb.velocity = moveDirection * speed;
        }
    }
}
