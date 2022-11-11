using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Doozy.Runtime.UIManager.Containers;

public class MainMenuUI : MonoBehaviour
{
    public UIContainer container;
    bool _switchBool = true;


     
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ContainerSwitch()
    {
        if(_switchBool)
        {
            _switchBool = false;
            container.Show();
        }
        else
        {
            _switchBool = true;
            container.Hide();
        }
    }

    public void Quitting()
    {
        Application.Quit();
    }
    
}
