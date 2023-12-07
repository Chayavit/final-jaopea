using System.Collections;
using UnityEngine;

public class CoverControll : MonoBehaviour
{
    public HealthBar _HP;
    public GameObject waterfall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cover")
        {
            _HP.DecreaseHP(10f);
            waterfall.SetActive(true);
        }
    }
}