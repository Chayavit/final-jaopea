using UnityEngine;

public class spin : MonoBehaviour
{
    public float rotationSpeed = 50f; // ความเร็วในการหมุน

    void Update()
    {
        // ให้ไอเท็มหมุนรอบๆ ตามแกน Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}