using System.Collections;
using UnityEngine;

public class itemHeal : MonoBehaviour
{
    public HealthBar _hb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heal")
        {
            _hb.IncreaseHP(12.0f);
            Destroy(other.gameObject);
        }
    }
}