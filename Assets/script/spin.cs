using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float spinSpeed = 1f;

    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, spinSpeed));
    }
}
