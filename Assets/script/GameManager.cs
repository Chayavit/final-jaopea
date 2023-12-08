using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Material skyboxMaterial; // Assign your skybox material in the Inspector

    void Start()
    {
        RenderSettings.skybox = skyboxMaterial; // Set the skybox material
    }
}
