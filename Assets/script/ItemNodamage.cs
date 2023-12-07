using System.Collections;
using UnityEngine;

public class ItemNodamage : MonoBehaviour
{
    public float invulnerabilityTime = 5f;
    public HealthBar hp;
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
        hp.setInvulnerable(false);
        yield return new WaitForSeconds(invulnerabilityTime);
        hp.setInvulnerable(true);

    }

}