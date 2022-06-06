using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTrigger : MonoBehaviour
{
    [SerializeField] DialogueManager diag;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset ink;
    private void Awake()
    {
        StartCoroutine(Dialogue());
    }
    private IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(3);
        diag = FindObjectOfType<DialogueManager>();
        diag.EnterDialogueMode(ink);
        yield return new WaitForSeconds(3);
        Debug.Log("Quitting");
        Application.Quit();
    }
}