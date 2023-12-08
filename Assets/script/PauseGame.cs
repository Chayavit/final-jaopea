using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenuUI;


    private bool isGamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        //Time.timeScale = 0;
        isGamePaused = true;

        // แสดง UI ที่บอกให้ผู้เล่นเล่นต่อหรือเริ่มใหม่
        pauseMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isGamePaused = false;

        // ซ่อน UI เมื่อเล่นต่อ
        pauseMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}