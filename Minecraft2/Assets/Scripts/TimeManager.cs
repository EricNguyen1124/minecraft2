using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slomofactor = 0.05f;

    public void DoSlowMo()
    {
        Time.timeScale = slomofactor;
        Time.fixedDeltaTime = Time.timeScale * 0.01f;
    }
}