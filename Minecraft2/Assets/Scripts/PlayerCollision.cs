using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    public Rigidbody rb;
    public TimeManager Timemanager;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("we hit a " + collision.collider);
        if(collision.gameObject.tag == "Obstacle")
        {
            rb.AddForce(0, 800, -800);
            rb.AddTorque(0, 300, 300);
            Invoke("DoIt", 0.2f);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    public void DoIt()
    {
        Timemanager.DoSlowMo();
    }

}
