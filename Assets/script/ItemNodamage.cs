using System.Collections;
using UnityEngine;

public class ItemNodamage : MonoBehaviour
{
    public float invulnerabilityTime = 5f;
    public HealthBar hp;
    public GameObject Effect;
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
        Effect.SetActive(true);
        hp.setInvulnerable(false);
        yield return new WaitForSeconds(invulnerabilityTime);
        hp.setInvulnerable(true);
        Effect.SetActive(false);
    }

}