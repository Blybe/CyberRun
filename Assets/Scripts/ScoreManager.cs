﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Dit is de ScoreManager die zorgt ervoor dat de Score word geupdate
    public static ScoreManager instance;

    public float Score;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        IncreaseScore(3 * Time.deltaTime);
    }
    public void IncreaseScore(float amount)
    {
        Score += amount;
    }
}
