using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("we hit a " + collision.collider);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
