using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImeneger : MonoBehaviour
{
    private timer _timer;
    public static bool GameisOver = false;

    public GameObject GameOverUI;

    public void update()
    { 
        if ((_timer.timerText).ToString() == "0:00")
        {
            Over();
        }
    }

    void Over()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameisOver = true;

    }
    public void Exit()
    {

    Debug.Log("quit");
        Application.Quit();
    }
}

