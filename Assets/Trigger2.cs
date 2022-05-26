using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    [SerializeField] DialogueManager diag;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset ink;

    private void Awake()
    {
        if(!diag.dialogueIsPlaying)
        {
        diag.EnterDialogueMode(ink);
        }
    }
}
