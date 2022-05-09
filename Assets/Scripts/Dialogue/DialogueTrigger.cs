using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] bool playerInRange;
    [SerializeField] DialogueManager diag;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset ink;

    private void Awake()
    {
        playerInRange = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void Update()
    {
        if(playerInRange && !diag.dialogueIsPlaying)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                diag.EnterDialogueMode(ink);
                Debug.Log("Loading Dialogue");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
