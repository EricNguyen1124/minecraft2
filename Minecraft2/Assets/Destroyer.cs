using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Update is called once per frame
    public void OnTriggerEnter(Collider destroy)
    {
        Destroy(destroy.gameObject);
    }
}
