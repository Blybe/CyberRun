using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CoinsManager.instance.IncreaseCoins(1);
        Destroy(gameObject);
    }
}
