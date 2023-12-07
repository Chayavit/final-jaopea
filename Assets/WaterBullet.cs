using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject particleSplash;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Hit");
            Instantiate(particleSplash, transform.position, Quaternion.identity);
            HealthBar hb = FindObjectOfType<HealthBar>();
            hb.DecreaseHP(2.0f);
        }
        Instantiate(particleSplash, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
