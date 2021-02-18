using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager instance;

    [SerializeField] GameObject Deathscreenpanel;

    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI CoinsUI;

    public float Score;
    public int Coins;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        Score = ScoreManager.instance.Score;
        Coins = CoinsManager.instance.Coins;

        ScoreUI.text = "Score:" + Mathf.RoundToInt(Score);
        CoinsUI.text = "Coins:" + Coins;
    }

    public void DeathScreen()
    {
        Deathscreenpanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
