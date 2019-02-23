using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour
{

    public void OnTriggerEnter()
    {
        Debug.Log("ball boy");
        Score.score += 10;
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
