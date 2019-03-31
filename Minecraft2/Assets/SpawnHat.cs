using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHat : MonoBehaviour
{
    // Start is called before the first frame update

    public MeshRenderer hat1;
    public MeshRenderer hat2;
    public MeshRenderer hat3;
    int rng;

    void Start()
    {
        hat1.enabled = false;
        hat2.enabled = false;
        hat3.enabled = false;
    }

    public void Hat()
    {
        if (Score.score >= 10)
        {
            Score.score = Score.score - 10;
            rng = Random.Range(1, 4);
            switch (rng)
            {
                case 1:
                    hat1.enabled = true;
                    hat2.enabled = false;
                    hat3.enabled = false;
                    break;
                case 2:
                    hat1.enabled = false;
                    hat2.enabled = true;
                    hat3.enabled = false;
                    break;
                case 3:
                    hat1.enabled = false;
                    hat2.enabled = false;
                    hat3.enabled = true;
                    break;
            }
        }
    }


}
