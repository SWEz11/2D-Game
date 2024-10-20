using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public GameObject endScreen;
    public GameObject logo;
    public TMP_Text endScoreText;
    public TMP_Text highScoreText;

    private void Update()
    {

        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        endScreen.SetActive(true);
        scoreText.gameObject.SetActive(true);
    }

    public void GameStart()
    {
        int highscore = PlayerPrefs.GetInt("score", 0);

        endScreen.SetActive(false);
        logo.SetActive(false);
        endScoreText.text = "score " + score;
        highScoreText.text = "Highscore " + highscore;
        if (score > highscore)
        {
            PlayerPrefs.SetInt("score", score);
            highscore = score;
        }
    }
}
