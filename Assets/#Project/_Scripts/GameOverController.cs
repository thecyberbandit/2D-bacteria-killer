using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Text scoreText;

    private int finalScore;

    private void Start()
    {
        AudioManager.instance.PlaySound("background");

        finalScore = PlayerPrefs.GetInt("score");
        scoreText.text = "Your Score: " + finalScore.ToString();
    }

    void Update()
    {
        if (Input.anyKeyDown && !Input.GetButtonDown("Fire1") && Input.GetAxis("Horizontal") == 0f && Input.GetAxis("Vertical") == 0f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
