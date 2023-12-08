using System.Collections;
using UnityEngine;

public class CoverControll : MonoBehaviour
{
    public HealthBar _HP;
    [SerializeField]
    private GameObject waterFallPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _HP.DecreaseHP(10f);
            Instantiate(waterFallPrefab, gameObject.transform.position, waterFallPrefab.transform.rotation);
        }
    }
}