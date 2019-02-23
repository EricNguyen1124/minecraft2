using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float PlayerControl = 500f;
    public float PlayerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (rb.position.y < -1){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,PlayerSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-PlayerControl * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(PlayerControl * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
