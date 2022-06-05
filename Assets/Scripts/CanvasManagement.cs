using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CanvasManagement : MonoBehaviour
{
    [SerializeField] private GameObject DialogueBox;

    private void Awake()
    {
        DialogueBox = GameObject.Find("Dialogue");
    }
    public void DialogueAppear(float timeToAppear)
    {
        DialogueBox.transform.DOMoveY(0f, 1.0f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            DialogueAppear(1.0f);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            DialogueDisappear(1.0f);
        }
    }

    public void DialogueDisappear(float timeToDisappear)
    {
        DialogueBox.transform.DOMoveY(-314.23f, 1.0f);
    }
}
