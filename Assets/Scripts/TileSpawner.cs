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
        // Hier Spawnt hij de Tiles in een Random volgorde en dan kan lijkt het dus alsof de speler er dus over heen rent terwijl hij stil staat
        if (spawnTime >= spawnTimer)
        {
            spawnTime = 0f;
            
            GameObject Tile = Instantiate(Tiles[Random.Range(0, Tiles.Length)], new Vector3(spawnLocation.position.x, spawnLocation.position.y, spawnLocation.position.z), spawnLocation.rotation);
            //Deze if statement zorgt ervoor dat als je aan het boosten bent dat hij de Values aanpast want anders loopt de Spawner Achter op de TileMover
            if (TileSpeed.instance.isBoosting)
                Tile.GetComponent<TileMover>().speed = boostSpeed;
            else
                Tile.GetComponent<TileMover>().speed = regularSpeed;
        }
    }
}
