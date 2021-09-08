using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text text;

    void Update()
    {
        if (Time.frameCount % 100 == 0)
        {
            int fps = (int)(1.0f / Time.deltaTime);
            text.text = fps + " FPS";
        }
    }
}
