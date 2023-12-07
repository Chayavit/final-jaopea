using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            Destroy(other.gameObject);
            score++;

            // ปรับปรุง UI ทุกครั้งที่มีการเปลี่ยนแปลงของคะแนน
            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        // แสดงผลบน UI
        scoreText.text = score + " Point";
    }
}