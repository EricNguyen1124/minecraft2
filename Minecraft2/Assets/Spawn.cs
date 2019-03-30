using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    Vector3 pos = new Vector3(0, 0.5f, 50);
    int rng;
    bool over = false;
    


    private void Update()
    {
        while(over == false)
        {
            Debug.Log("spawn");
            Instantiate(prefab, new Vector3(0, 0.5f, 80), Quaternion.identity);
        }
    }
}
