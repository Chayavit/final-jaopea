using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemy : MonoBehaviour
{
    private GameObject target;
    public Transform player; // Reference to the player GameObject
    public float detectionDistance = 10;

    private void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            shoot s = GetComponentInChildren<shoot>();
            if (distanceToPlayer <= detectionDistance)
            {
                s.SetCanShoot(true);
                Vector3 newTranform = new Vector3(player.transform.position.x, player.transform.position.y + 1.2f, player.transform.position.z);
                transform.LookAt(newTranform);
            }
            else
            {
                s.SetCanShoot(false);
            }
            
        }
    }
}
