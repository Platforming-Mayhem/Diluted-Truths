using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManagement : MonoBehaviour
{
    [SerializeField] private GameObject DialogueBox;
    [SerializeField] private GameObject GUI;

    public void DialogueAppear(float timeToAppear)
    {
        int tween1;
        bool test = false;
        tween1 = LeanTween.move(GUI, new Vector3(0f, -314.23f, 0f), timeToAppear).setEase(LeanTweenType.easeOutQuad).setOnCompleteParam(test = true).id;
        Debug.Log(tween1);
        Debug.Log(test);
        Debug.Log("Tweened");
    }
}
