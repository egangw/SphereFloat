using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillateBall : MonoBehaviour
{

    Vector3 velocity = new Vector3(0.0f, .25f, 0.0f);
    public float floorHeight = 0.0f;
    public float sleepThreshold = 1f;
    public float gravity = -1f;

    void Start()
    {
        transform.position = new Vector3(-5.095f, 3.988f, 2.319f);
    }

    void FixedUpdate()
    {
        if (velocity.magnitude > sleepThreshold || transform.position.y > floorHeight)
        {
            velocity += new Vector3(0.0f, gravity * Time.fixedDeltaTime, 0.0f);
        }

        transform.position += velocity * Time.fixedDeltaTime;
        if (transform.position.y <= floorHeight)
        {
            transform.position = new Vector3(0.0f, floorHeight, 0.0f);
            velocity.y = -velocity.y;
        }
    }
}