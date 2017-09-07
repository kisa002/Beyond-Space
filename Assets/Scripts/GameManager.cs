using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int story = 1;

    public Material mat;

    private void Start()
    {
        RenderSettings.skybox = mat;
    }
}
