using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    public float destroyTime = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);

            Destroy(bulletInstance.gameObject, destroyTime);
        }
    }
}