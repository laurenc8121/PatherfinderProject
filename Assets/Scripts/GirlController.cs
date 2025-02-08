using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
