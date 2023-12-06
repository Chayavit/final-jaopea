using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
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
                
            }
        
    }

}