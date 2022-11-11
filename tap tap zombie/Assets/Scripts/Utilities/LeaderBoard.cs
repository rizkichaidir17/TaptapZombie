using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class LeaderBoard : MonoBehaviour
{

    public int highScore;
    string highScoreKey = "HighScore";
    public TMP_Text highscoreText;

    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        //use this value in whatever shows the leaderboard.
    }

    private void Update()
    {
        highscoreText.text = highScore.ToString();
    }

}