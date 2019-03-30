using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    Vector3 pos = new Vector3(0, 0.5f, 90);
    float rng;
    bool over = false;


    WaitForSeconds wait = new WaitForSeconds(1.5f);

    public IEnumerator Start()
    {
        while(over == false)
        {
            rng = Random.value;
            if(rng < 0.2)
            {
                Debug.Log("spawn obstacle 1");
                Instantiate(obstacle1, pos, Quaternion.identity);
            }
            else if (rng > 0.2 && rng < 0.4)
            {
                Debug.Log("spawn obstacle 2");
                Instantiate(obstacle2, pos, Quaternion.identity);
            }
            else if (rng > 0.4 && rng < 0.6)
            {
                Debug.Log("spawn obstacle 3");
                Instantiate(obstacle3, pos, Quaternion.identity);
            }
            else if (rng > 0.6 && rng <0.8)
            {
                Debug.Log("spawn obstacle 4");
                Instantiate(obstacle4, pos, Quaternion.identity);
            }
            else if (rng > 0.8 && rng <1.0)
            {
                Debug.Log("spawn obstacle 5");
                Instantiate(obstacle5, new Vector3(4.64f,0.5f,90), Quaternion.identity);
            }
            yield return wait;
        }
    }
}
