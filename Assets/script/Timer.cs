﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timer = 0f;
    public float targetTime = 186f; // 3 นาที
    public Text timerText;
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private CoinCollector coinColect;

    void Update()
    {
        timer += Time.deltaTime;

        // ตรวจสอบว่าเวลาผ่านไปถึงเวลาที่กำหนดหรือไม่
        if (timer >= targetTime)
        {
            // เปลี่ยนฉากไปที่ "กล้อง1"
            scoreManager.FinalizeScore(coinColect.GetPlayerScore());
            SceneManager.LoadScene("menu 3");
        }

        // แสดงเวลาที่เหลือ
        DisplayTime(targetTime - timer);
    }


    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);

        // แสดงเวลาบน UI Text
        if (timerText != null)
        {
            timerText.text = "Time: " + timeText;
        }
    }
}