using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (Vector3.Scale(new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).normalized * 3.0f, Vector3.one - Vector3.up) + Vector3.up * rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
        }
    }
}
