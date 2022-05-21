using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float minTime;
    [SerializeField] private float secTime;
    [SerializeField] private Text timerText;
    private float timer;
    public bool isStart = false;
    private void Awake()
    {
        timer = (minTime * 60) + secTime; 
    }

    private void Update()
    {
        TimerUpdate();
    }

    private void TimerUpdate()
    {
        if (!isStart)
            return;

        if (timer < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        timerText.text = string.Format("{0}{1:D2}{2:D2}", (int)timer / 60, ":", (int)timer % 60);
        if (timer <= 0)
        {
            timer = 0;
        }

        timer -= Time.deltaTime;
    }

    public void GameStart()
    {
        isStart = true;
    }

}
