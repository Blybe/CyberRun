using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float snapLocation;
    private void Update()
    {  
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x <= snapLocation)
        {
            Destroy(gameObject);
        }
    }
}
