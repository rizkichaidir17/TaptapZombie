using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Ins;
    public GameObject panelPause;
    public GameObject panelGameOver;
    bool isPause = false;


    private void Awake()
    {
        Time.timeScale = 1f;
        Ins = this;
    }

    private void Start()
    {
        UIHandler.score = 0;
        panelPause.SetActive(false);
        panelGameOver.SetActive(false);
    }
    private void Update()
    {
 
    }

    public void ButtonUnpause()
    {
        Time.timeScale = 1f;
        panelPause.SetActive(false);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void TryAgain()
    {
        Time.timeScale = 1;
        Invoke("LoadScene", 1);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseMenu()
    {   if (isPause != true)
        {
            isPause = true;
            Time.timeScale = 0;
            panelPause.SetActive(true);
        }
    }
}
