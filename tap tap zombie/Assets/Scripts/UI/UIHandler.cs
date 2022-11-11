using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Ins;
    [SerializeField] Text scoreText;
    public static int score;

    private void Awake()
    {
        Ins = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + 0;
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score : " + score.ToString();
    }

}
