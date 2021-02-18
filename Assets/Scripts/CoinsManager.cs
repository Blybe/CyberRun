using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{
    // Dit is de Coinsmanager die Zorgt ervoor dat de Coins op de UI worden geupdate
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
