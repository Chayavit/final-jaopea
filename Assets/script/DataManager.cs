using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    [Header("Don't change these value during play mode")]
    public int playerScore = 0;        
    public float soundVolumn = 0.5f;    //Save in range 0-1

    private string scoreKey = "PlayerScore";
    private string soundKey = "SoundVal";

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

    #region SETTER
    public void FinalizeScore(int amount)
    {
        playerScore = amount;
        PlayerPrefs.SetInt(scoreKey, playerScore);
    }
    public void SaveSound(float volumn)
    {
        soundVolumn = volumn;
        PlayerPrefs.SetFloat(soundKey, soundVolumn);
    }
    #endregion

    #region GETTER
    public int GetScore()
    {
        return PlayerPrefs.GetInt(scoreKey);
    }

    public float GetSoundVolumn()
    {
        return PlayerPrefs.GetFloat(soundKey);
    }

    #endregion
    // Optionally, you can reset the score
    public void ResetScore()
    {
        playerScore = 0;
        PlayerPrefs.DeleteKey(scoreKey);
    }
}
