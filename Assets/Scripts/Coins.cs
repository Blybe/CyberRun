using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //Coins die worden hier doorgegeven aan de CoinsManager om vervolgens op de UI te verschijnen
    private void OnTriggerEnter(Collider other)
    {
        CoinsManager.instance.IncreaseCoins(1);
        Destroy(gameObject);
    }
}
