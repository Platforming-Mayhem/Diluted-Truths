using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public Image image;
    public IEnumerator FadeIn()
    {
        for(; ; )
        {
            yield return new WaitForSeconds(Time.deltaTime);
            image.color += new Color(0f, 0f, 0f, Time.deltaTime);
        }
    }
    public IEnumerator FadeOut()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(Time.deltaTime);
            image.color -= new Color(0f, 0f, 0f, Time.deltaTime);
        }
    }
    private void Update()
    {
        
    }
}
