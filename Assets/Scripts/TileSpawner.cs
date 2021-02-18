using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public static TileSpawner instance;
    public float spawnTimer;
    private float spawnTime;
    [SerializeField] private GameObject[] Tiles;
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private float regularSpeed = 8f, boostSpeed;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >= spawnTimer)
        {
            spawnTime = 0f;
            
            GameObject Tile = Instantiate(Tiles[Random.Range(0, Tiles.Length)], new Vector3(spawnLocation.position.x, spawnLocation.position.y, spawnLocation.position.z), spawnLocation.rotation);
            if (TileSpeed.instance.isBoosting)
                Tile.GetComponent<TileMover>().speed = boostSpeed;
            else
                Tile.GetComponent<TileMover>().speed = regularSpeed;
        }
    }
}
