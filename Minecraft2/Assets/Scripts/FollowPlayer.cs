﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform trnsfrm;
    public Vector3 CameraOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = trnsfrm.position + CameraOffset;
    }
}