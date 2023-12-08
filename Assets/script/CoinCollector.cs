using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public AudioClip collectSound;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = collectSound;
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            Destroy(other.gameObject);
            score++;
            ScoreManager.instance.SetScore(score);

            PlayCollectSound();
            // ปรับปรุง UI ทุกครั้งที่มีการเปลี่ยนแปลงของคะแนน
            UpdateScoreUI();
        }
    }
    private void PlayCollectSound()
    {
        audioSource.Play();
    }
    private void UpdateScoreUI()
    {
        // แสดงผลบน UI
        scoreText.text = score + " Point";
    }
    public int GetPlayerScore()
    {
        return score;
    }
}