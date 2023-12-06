using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image hpBar;
    private float maxhpVal = 25.0f;
    public float hpVal;

    private void Update()
    {
        hpBar.fillAmount = hpVal / maxhpVal;
    }

    public void DecreaseHP(float val)
    {
        hpVal -= val;
    }
}
