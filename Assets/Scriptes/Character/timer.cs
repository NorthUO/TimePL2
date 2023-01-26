using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] public Text timerText;
    //private UIManager uiManager;
    //[field: SerializeField] public float damagetime { get; private set; };

    public float _timeLeft = 0f;
    private bool _timerOn = false;

    private void Start()
    {
        _timeLeft = time;
        _timerOn = true;
        //uiManager = FindObjectofType<UIManager>();
    }

    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                UpdateTimeText();
            }
            else
            {
                _timeLeft = time;
                _timerOn = false;
            }
        }
        //if (_timeLeft <= 0)
        //{ uiManager.GameOver(); }
    }
    //private void TimeDamage(float damagetime)
    //{
    //    if (_timerOn)
    //        if (_timeLeft > 0)
    //        {
    //            _timeLeft -= damagetime;
    //            UpdateTimeText();
    //        }
    //        else
    //        {
    //            _timeLeft = time;
    //            _timerOn = false;
    //        }
    //}

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}
