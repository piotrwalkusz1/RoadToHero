using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleCutscene : MonoBehaviour
{
    public Image imageObject;
    public List<Sprite> sprites;
    public float singleSceneDuration = 5.0f;
    public float initialFadeOutDuration = 1.0f;
    public float fadeOutDuration = 0.5f;
    public UnityEvent onEnd;

    private float time = 0;
    private int currentSpriteIndex = 0;
    private bool initialFadeOut = true;
    private bool end = false;

    void Start()
    {
        imageObject.color = Color.black;
        if (sprites.Count > 0)
        {
            imageObject.sprite = sprites[0];
        }
        else
        {
            endCutscene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            return;
        }

        time += Time.deltaTime;

        if (initialFadeOut)
        {
            if (time > initialFadeOutDuration)
            {
                initialFadeOut = false;
                time = 0.0f;
            }
        }
        else
        {
            float color = time < fadeOutDuration ? (time / fadeOutDuration) : 1 - Mathf.Clamp01((time + fadeOutDuration - singleSceneDuration) / fadeOutDuration);
            imageObject.color = new Color(color, color, color);
            if (time > singleSceneDuration)
            {
                time = 0.0f;
                currentSpriteIndex++;
                if (currentSpriteIndex < sprites.Count)
                {
                    imageObject.sprite = sprites[currentSpriteIndex];
                }
                else
                {
                    endCutscene();
                }
            }
        }
    }

    private void endCutscene()
    {
        end = true;
        onEnd.Invoke();
    }
}
