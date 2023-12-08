using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorDisplayer : MonoBehaviour
{
    public bool isShowCursor = false;
    void Start()
    {
        if (isShowCursor)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }
}
