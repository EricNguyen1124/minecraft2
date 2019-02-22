using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
