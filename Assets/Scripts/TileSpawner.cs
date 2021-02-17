using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] private float spawnTimer;
    private float spawnTime;
    [SerializeField] private GameObject[] Tiles;
    [SerializeField] private Transform spawnLocation;

    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >= spawnTimer)
        {
            spawnTime = 0f;
            Instantiate(Tiles[Random.Range(0, Tiles.Length)], new Vector3(20, spawnLocation.position.y, spawnLocation.position.z), spawnLocation.rotation);
        }
    }
}
