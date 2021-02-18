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
        //Hier worden alle UI in de Game geupdate op basis van hoe veel coins je hebt en hoeveel score
        Score = ScoreManager.instance.Score;
        Coins = CoinsManager.instance.Coins;

        ScoreUI.text = "Score:" + Mathf.RoundToInt(Score);
        CoinsUI.text = "Coins:" + Coins;
    }

    //Dit is om de Buttons te Assignen voor de Mogelijke dingen die de Buttons kunnen doen
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
        SceneManager.LoadScene("StartScene");
    }
}
