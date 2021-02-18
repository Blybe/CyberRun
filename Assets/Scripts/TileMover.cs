using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMover : MonoBehaviour
{
    public float speed = 8f;
    [SerializeField] private float snapLocation;

    private void Start()
    {
        TileSpeed.instance.changeSpeed += ChangeSpeed;
    }
    private void Update()
    {  
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x <= snapLocation)
        {
            Destroy(gameObject);
        }
    }

    private void ChangeSpeed(float _speed)
    {
        speed = _speed;
    }
}
