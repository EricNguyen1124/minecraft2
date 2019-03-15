using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float PlayerControl = 500f;
    public float PlayerSpeed;
    float horizontal;

    private void Update()
    {
        if (rb.position.y < 0){
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<PlayerCollision>().DoIt();
        }


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,PlayerSpeed * Time.deltaTime);

        horizontal = Input.GetAxis("Horizontal") * PlayerControl * Time.deltaTime;
        rb.transform.Translate(horizontal, 0, 0);
    }
}
