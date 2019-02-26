using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float PlayerControl = 500f;
    public float PlayerSpeed;
    bool left = false;
    bool right = false;

    private void Update()
    {
        if (rb.position.y < 0){
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<PlayerCollision>().DoIt();
        }
        if (Input.GetKey("a"))
        {
            left = true;
        }
        else if (Input.GetKey("d"))
        {
            right = true;
        }
        else
        {
            left = false;
            right = false;
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,PlayerSpeed * Time.deltaTime);

        if (left == true)
        {
            rb.AddForce(-PlayerControl * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (right == true)
        {
            rb.AddForce(PlayerControl * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
