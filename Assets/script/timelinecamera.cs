using System.Collections;
using UnityEngine;

public class timelinecamera : MonoBehaviour
{
    public GameObject cameratimeline;
    public GameObject mainCamera;
    public float waitingGame = 5f;

    void Start()
    {
        mainCamera.SetActive(true);
        StartCoroutine(cooldowngameplay());
    }

    private IEnumerator cooldowngameplay()
    {
        yield return new WaitForSeconds(0.05f);
        mainCamera.SetActive(false);
        yield return new WaitForSeconds(waitingGame);
        cameratimeline.SetActive(false);
        mainCamera.SetActive(true);
    }
}