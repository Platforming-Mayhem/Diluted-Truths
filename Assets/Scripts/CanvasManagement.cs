using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManagement : MonoBehaviour
{
    [SerializeField] private GameObject DialogueBox;
    [SerializeField] private GameObject GUI;
    public bool DialogueOut = false;

    public void DialogueAppear(float timeToAppear)
    {
        int tween1;
        int tween2;
        bool test = false;
        tween1 = LeanTween.moveY(GUI, -314.23f, timeToAppear).setEase(LeanTweenType.easeOutQuad).setOnCompleteParam(test = true).id;
        if(test)
        {
            tween2 = LeanTween.moveY(DialogueBox, 0f, timeToAppear).setEase(LeanTweenType.easeOutQuad).setOnCompleteParam(test = false).id;
        }
        DialogueOut = true;
    }

    public void DialogueDisappear(float timeToDisappear)
    {
        int tween1;
        int tween2;
        bool test = false;
        tween1 = LeanTween.moveY(DialogueBox, -314.23f, timeToDisappear).setEase(LeanTweenType.easeOutQuad).setOnCompleteParam(test = true).id;
        if (test)
        {
            tween2 = LeanTween.moveY(GUI, 0f, timeToDisappear).setEase(LeanTweenType.easeOutQuad).setOnCompleteParam(test = false).id;
        }
        DialogueOut = false;
    }
}
