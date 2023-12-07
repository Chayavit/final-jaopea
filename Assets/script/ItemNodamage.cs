using System.Collections;
using UnityEngine;

public class ItemNodamage : MonoBehaviour
{
    private bool isInvulnerable = false;
    public float invulnerabilityTime = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "nodamage")
        {
            StartCoroutine(cooldowngamemode0());
            Destroy(other.gameObject);
        }
    }
    private IEnumerator cooldowngamemode0()
    {
        isInvulnerable = true;
        yield return new WaitForSeconds(invulnerabilityTime);
        isInvulnerable = false;

    }
}