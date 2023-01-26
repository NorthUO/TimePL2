using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
    private int _score;
    

    [SerializeField] private TextMeshProUGUI _scoreText;

    public void AddScore(int value)
    {
        _score += value;
        UpdateUI();
    }

    public void GetDamage(int value)
    {
        _score -= value;
        UpdateUI();

    }

    //private void UpdateTimeText()
    //{
    //    if (_timeLeft < 0)
    //        _timeLeft = 0;

    //    float minutes = Mathf.FloorToInt(_timeLeft / 60);
    //    float seconds = Mathf.FloorToInt(_timeLeft % 60);
    //    timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    //}

    private void UpdateUI()
    {
        _scoreText.text = "Score: " + _score.ToString();
    }
}
