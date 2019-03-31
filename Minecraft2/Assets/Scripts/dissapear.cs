using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name=="Cube")
        {
            Debug.Log("ball boy");
            Score.score += 10;
            Destroy(gameObject);
        }
        
    }

}
