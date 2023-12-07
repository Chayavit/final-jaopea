using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    void Start()
    {
        // ตั้งค่าค่าเริ่มต้นของ Slider
        volumeSlider.value = audioSource.volume;

        // ตั้ง Event Listener สำหรับ Slider
        volumeSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    void OnSliderValueChanged()
    {
        // เปลี่ยนค่าเสียงตามค่า Slider
        audioSource.volume = volumeSlider.value;
    }
}