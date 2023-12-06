using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    public HealthBar _hb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _hb.DecreaseHP(5);
        }
    }
}
