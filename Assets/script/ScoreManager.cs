using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int playerScore = 0;

    private string scoreKey = "PlayerScore";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        ResetScore();
    }

    public void FinalizeScore(int score)
    {
        SetScore(score);
    }

    public void SetScore(int amount)
    {
        playerScore = amount;
        PlayerPrefs.SetInt(scoreKey, playerScore);
    }

    public int GetScore()
    {
        return PlayerPrefs.GetInt(scoreKey);
    }

    // Optionally, you can reset the score
    public void ResetScore()
    {
        playerScore = 0;
        PlayerPrefs.DeleteKey(scoreKey);
    }
}
