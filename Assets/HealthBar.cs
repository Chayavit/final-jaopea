using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image hpBar;
    public float maxHP;
    public float curHP;

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        hpBar.fillAmount = curHP / maxHP;
    }

    public void DecreaseHP(float val)
    {
        curHP -= val;
    }
}
