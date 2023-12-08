using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class WinDetection : MonoBehaviour
{
    [SerializeField]
    private CoinCollector coinColect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            // เปลี่ยนไปยัง Scene Menu 3
            DataManager.instance.FinalizeScore(coinColect.GetPlayerScore());
            SceneManager.LoadScene("menu 2");
        }

    }

}