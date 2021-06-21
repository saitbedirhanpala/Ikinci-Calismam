﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z>topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z<lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Oyun bitti La Tırrek");
            Debug.Log("Game Over and Your Point is = { }"+topBound);
        }
    }
}
