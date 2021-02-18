using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{
    public static CoinsManager instance;

    public int Coins;

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseCoins(int amount)
    {
        Coins += amount;
    }
}
