using UnityEngine;
using UnityEngine.SceneManagement;

public class UiControll : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void Quit()
    {
        // ปิดแอปพลิเคชัน
        Application.Quit();
    }
}
