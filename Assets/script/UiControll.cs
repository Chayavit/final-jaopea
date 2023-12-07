using UnityEngine;
using UnityEngine.SceneManagement;

public class UiControll : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}