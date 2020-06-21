﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 30, Time.deltaTime * 50, Time.deltaTime * 20));  //Rotating gameobject about all the axes.
        
    }
}
