using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Score die worden hier doorgegeven aan de ScoreManager om vervolgens op de UI te verschijnen
    public static Score instance;
    private void Awake()
    {
        instance = this;
    }
    public void Update()
    {
        ScoreCounter();
    }
    private void ScoreCounter()
    {
        ScoreManager.instance.IncreaseScore(3 * Time.deltaTime);
    }
}
