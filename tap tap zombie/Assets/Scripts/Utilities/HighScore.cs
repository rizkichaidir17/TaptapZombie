using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    
    public int highScore = 0;
    string highScoreKey = "HighScore";

    void Start()
    {
        //Get the highScore from player prefs if it is there, 0 otherwise.
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    void Update()
    {
        
    }

    void OnDisable()
    {

        //If our scoree is greter than highscore, set new higscore and save.
        if (UIHandler.score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, UIHandler.score);
            PlayerPrefs.Save();
        }
    }

}
