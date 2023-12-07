using UnityEngine;
using UnityEngine.SceneManagement;

public class UiControll : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject SoundSlider;
    private bool closeSound = false;

    private void Start()
    {
        if(SoundSlider != null)
        {
            SoundSlider.SetActive(false);
        }
    }
    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void Quit()
    {
        // ปิดแอปพลิเคชัน
        Application.Quit();
    }

    public void SetActive()
    {
        SoundSlider.SetActive(true);
        SoundSlider.SetActive(!closeSound);
        closeSound = !closeSound;
    }
}
