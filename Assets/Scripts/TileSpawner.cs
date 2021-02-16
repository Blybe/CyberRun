using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] private float spawnTimer;
    private float spawnTime;
    [SerializeField] private GameObject Tile;
    [SerializeField] private Transform spawnLocation;

    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >= spawnTimer)
        {
            spawnTime = 0f;
            Instantiate(Tile, spawnLocation.position, spawnLocation.rotation);
        }
    }
}
