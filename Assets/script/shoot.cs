using System.Collections;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public int bulletsPerSecond = 3; // จำนวนกระสุนที่ต้องการยิงต่อวินาที
    public float shootInterval = 3f;
    public float bulletSpeed;

    private void Start()
    {
        // เริ่ม Coroutine สำหรับการยิงกระสุน
        StartCoroutine(ShootBullets());
    }

    IEnumerator ShootBullets()
    {
        while (true)
        {
            // พักยิงกระสุน 3 วินาที
            yield return new WaitForSeconds(shootInterval);

            // ยิงกระสุน
            for (int i = 0; i < bulletsPerSecond; i++)
            {
                ShootBullet();
                yield return new WaitForSeconds(1f / bulletsPerSecond); // พักเวลาระหว่างการยิง 1 ลูก
            }
        }
    }

    void ShootBullet()
    {
        // Instantiate กระสุนที่ตำแหน่ง bulletSpawnPoint
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody bulletRigidbody = bulletPrefab.GetComponent<Rigidbody>();
        if (bulletRigidbody != null)
        {
            // กำหนดความเร็วให้กับ Rigidbody เพื่อให้ prefab มีความเร็วเพิ่มขึ้นและพุ่งไปด้านหน้า
            bulletRigidbody.velocity = bulletPrefab.transform.forward * 1700f;
        }
        else
        {
            Debug.LogError("Prefab is missing Rigidbody component.");
        }
    }
}