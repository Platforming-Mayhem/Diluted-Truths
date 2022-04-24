using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatableCharacter : MonoBehaviour
{
    [SerializeReference]
    private int frameRate = 24;

    [SerializeReference]
    private int framesPerRow = 12;

    [SerializeReference]
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitToPresentNextFrame");
        offsetAmount = 0.0f;
    }

    float offsetAmount;

    IEnumerator WaitToPresentNextFrame()
    {
        for(; ; )
        {
            if (offsetAmount >= 1.0f)
            {
                offsetAmount = 0.0f;
            }
            yield return new WaitForSeconds((float)(1.0f / frameRate));
            if(offsetAmount >= 1.0f)
            {
                offsetAmount = 0.0f;
            }
            else
            {
                offsetAmount += (float)(1.0f / framesPerRow);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset = new Vector2(offsetAmount, 0.0f);
    }
}
