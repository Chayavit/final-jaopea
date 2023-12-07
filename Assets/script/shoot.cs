using System.Collections;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public int bulletsPerSecond = 3;
    public float bulletSpeed;
    [SerializeField]
    private Animator anim;
    private bool isCanShoot;

    private void Start()
    {
        isCanShoot = false;
        StartCoroutine(ShootBullets());
    }

    IEnumerator ShootBullets()
    {
        while (true)
        {
            if (isCanShoot)
            {
                anim.SetTrigger("Shoot");
                yield return new WaitForSeconds(1.0f);
                // ยิงกระสุน
                for (int i = 0; i < bulletsPerSecond; i++)
                {
                    ShootBullet();
                    yield return new WaitForSeconds(0.05f);
                }
            }
            yield return new WaitForSeconds(2.5f);
        }
    }

    public void SetCanShoot(bool isCanShoot)
    {
        this.isCanShoot = isCanShoot;
    }

    void ShootBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody rb = newBullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 direction = Quaternion.Euler(0, transform.parent.eulerAngles.y, 0) * Vector3.forward;
            rb.velocity = direction * bulletSpeed;
        }
        Destroy(newBullet, 2.0f);
    }
}