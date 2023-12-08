using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class WinDetection : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private CoinCollector coinColect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            // เปลี่ยนไปยัง Scene Menu 3
            scoreManager.FinalizeScore(coinColect.GetPlayerScore());
            SceneManager.LoadScene("menu 2");
        }

    }

}