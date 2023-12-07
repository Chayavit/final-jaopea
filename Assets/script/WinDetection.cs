using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class WinDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            // เปลี่ยนไปยัง Scene Menu 3
            SceneManager.LoadScene("menu 2");
        }

    }

}