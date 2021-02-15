using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    private float turnSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, turnSpeed, 0f);
    }
}
