using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RotatorTricky : MonoBehaviour
    
{
    // Start is called before the first frame update
    private int r = 3;
    private int angle = 1;

    private float pickupValueX;
    private float pickupValueZ;
    private float counter = 0;
    public float offset = 50;

    void Start()
    {
        pickupValueX = r * Mathf.Sin(1);
        pickupValueZ = r * Mathf.Cos(1);
    }

// Update is called once per frame
    void Update()
    {
        float xNew = r * Mathf.Sin(counter);
        float zNew = r * Mathf.Cos(counter);

        transform.position = new Vector3(xNew - offset, 1, zNew - offset);
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        counter += 1.0f * Time.deltaTime;
    }

}