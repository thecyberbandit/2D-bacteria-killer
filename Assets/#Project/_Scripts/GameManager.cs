using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text timerText;
    public Text scoreText;

    public int score;

    private bool isGameStarted;
    private float timeLeft = 60f;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        AudioManager.instance.StopSound("background");

        isGameStarted = true;
        score = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (isGameStarted)
        {
            int temp = (int)timeLeft;
            timerText.text = "Time Left: " + temp.ToString();

            timeLeft -= Time.deltaTime;
        }

        if (timeLeft < 0)
        {
            GameOver();
        }

        scoreText.text = "Score: " + score.ToString();
    }

    void GameOver()
    {
        PlayerPrefs.SetInt("score", score);
        SceneManager.LoadScene(2);
    }
}
