using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMovementObject : MonoBehaviour
{
    [SerializeReference]
    private int frameRate = 24;

    [SerializeReference]
    private int framesPerRow = 12;

    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        offsetAmount = 0.0f;
        originalPosition = transform.position;
        StartCoroutine("WaitToPresentNextFrame");
    }


    float offsetAmount;

    IEnumerator WaitToPresentNextFrame()
    {
        for (; ; )
        {
            if (offsetAmount >= 1.0f)
            {
                offsetAmount = 0.0f;
            }
            yield return new WaitForSeconds((float)(1.0f / frameRate));
            if (offsetAmount >= 1.0f)
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
        transform.position = new Vector3(originalPosition.x - (offsetAmount * 22.12143f), transform.position.y, transform.position.z);
    }
}
