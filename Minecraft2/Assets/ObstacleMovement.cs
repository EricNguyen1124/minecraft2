using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float ObstacleSpeed;
    public Rigidbody rb; 

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -ObstacleSpeed * Time.deltaTime);
    }
}
