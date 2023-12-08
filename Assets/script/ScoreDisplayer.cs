using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private void Start()
    {
        scoreText.text = "Score: " + ScoreManager.instance.GetScore().ToString();
    }
}
