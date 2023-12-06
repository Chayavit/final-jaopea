using System.Collections;
using UnityEngine;

public class fastrun : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float fastSpeed = 10f;
    public float speedBoostDuration = 3f;

    private float currentSpeed;
    private bool isSpeedBoosted = false;

    void Start()
    {
        currentSpeed = normalSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            CollectItem();
        }

        // โค้ดเคลื่อนที่ตัวละครตาม currentSpeed ที่อัพเดททุกเฟรม
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    void CollectItem()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 2f);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Milk"))
            {
                Destroy(collider.gameObject);

                // เริ่ม Coroutine สำหรับการวิ่งไว
                StartCoroutine(SpeedBoost());
                break;  // หยุดทำการลูปหาของเมื่อเจอของที่ต้องการแล้ว
            }
        }
    }

    IEnumerator SpeedBoost()
    {
        if (!isSpeedBoosted)
        {
            // เพิ่มความเร็ว
            currentSpeed = fastSpeed;
            isSpeedBoosted = true;

            // รอเวลา speedBoostDuration วินาที
            yield return new WaitForSeconds(speedBoostDuration);

            // คืนความเร็วเป็นปกติ
            currentSpeed = normalSpeed;
            isSpeedBoosted = false;
        }
    }
}