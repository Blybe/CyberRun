using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int Score;

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseScore(int amount)
    {
        Score += amount;
    }
}
