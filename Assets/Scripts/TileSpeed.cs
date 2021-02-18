using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TileSpeed : MonoBehaviour
{
    public static TileSpeed instance;

    private void Awake()
    {
        instance = this;
    }
    public delegate void ChangeSpeed(float speed);
    public event ChangeSpeed changeSpeed;

    [SerializeField] private float regularSpeed = 8f, boostSpeed;
    [SerializeField] private float regularSpawnTime = 1.35f, boostSpawnTime;
    public bool isBoosting = false;
    [SerializeField] private float speedBoostTime;
    private float tileSpeedTimer;

    private void Update()
    {
        if (isBoosting)
        {
            tileSpeedTimer += Time.deltaTime;
            if (tileSpeedTimer >= speedBoostTime)
            {
                TileSpawner.instance.spawnTimer = regularSpawnTime;
                tileSpeedTimer = 0f;
                isBoosting = false;
                changeSpeed.Invoke(regularSpeed);
            }
        }
    }
    public void ActivateSpeedBoost()
    {
        changeSpeed.Invoke(boostSpeed);
        TileSpawner.instance.spawnTimer = boostSpawnTime;
        isBoosting = true;
    }
}
