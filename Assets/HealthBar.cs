using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image hpBar;
    public float maxHP;
    public float curHP;
    bool iscantdo = false;

    private void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        hpBar.fillAmount = curHP / maxHP;

        if (curHP <= 0)
        {
            SceneManager.LoadScene("menu 3");
        }
    }

    public void DecreaseHP(float val)
    {
        if (iscantdo == true)
        {
            curHP -= val;
        }
        
    }
}
