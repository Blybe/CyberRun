using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.IncreaseScore(1);
        Destroy(gameObject);
    }
}
