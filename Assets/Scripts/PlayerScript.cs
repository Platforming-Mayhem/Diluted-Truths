using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] CanvasManagement canvas;
    [SerializeField] DialogueManager diag;
    

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!diag.dialogueIsPlaying)
        {
            Move();
        }
    }

    private void Move()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * movementSpeed;
    }
    /*
    void NPCTalk()
    {
        if(Input.GetKeyDown(KeyCode.F) && !canvas.DialogueOut)
        {
            Debug.Log("Test");
            canvas.DialogueAppear(1.5f);
        }
        if (Input.GetKeyDown(KeyCode.X) && canvas.DialogueOut)
        {
            Debug.Log("Test2");
            canvas.DialogueDisappear(1.5f);
        }
    }
    */
}
