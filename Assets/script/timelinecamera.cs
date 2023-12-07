using System.Collections;
using UnityEngine;

public class timelinecamera : MonoBehaviour
{
    public GameObject cameratimeline;
    public float waitingGame = 5f;

    void Start()
    {
        StartCoroutine(cooldowngameplay());
    }

    private IEnumerator cooldowngameplay()
    {
        yield return new WaitForSeconds(waitingGame);
        cameratimeline.SetActive(false);
    }
}