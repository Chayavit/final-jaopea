using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("win"))
        {
            // เปลี่ยนไปยัง Scene Menu 3
            SceneManager.LoadScene("3");
        }
    }
}