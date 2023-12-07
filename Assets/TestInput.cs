using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestInput : MonoBehaviour
{
    public HealthBar _hb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _hb.DecreaseHP(5);
        }
    }
}
