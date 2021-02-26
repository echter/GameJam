﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject cameraRagdollPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraRagdollPosition.transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z - 10);
    }
}
