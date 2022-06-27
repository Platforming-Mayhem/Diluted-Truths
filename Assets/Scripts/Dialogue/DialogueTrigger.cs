using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] bool playerInRange;
    [SerializeField] DialogueManager diag;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset ink;
    PlayerScript player;

    private void Awake()
    {
        playerInRange = false;
        diag = FindObjectOfType<DialogueManager>();
        player = FindObjectOfType<PlayerScript>();
    }

    public void SetInky(TextAsset inky){
        ink = inky;
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
            if(ink){
                player.FGUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("F"))
                {
                    diag.EnterDialogueMode(ink);
                    Debug.Log("Loading Dialogue");
                }
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.FGUI.SetActive(false);
            playerInRange = false;
        }
    }
}
