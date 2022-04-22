using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPapers : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            rb.AddForce(Vector3.Scale(transform.position - collision.transform.position, Vector3.one - Vector3.up) * 3.0f, ForceMode.Impulse);
            Debug.Log("FLY YOU FOOLS");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.AddForce(Vector3.Scale(transform.position - other.transform.position, Vector3.one - Vector3.up) * 3.0f, ForceMode.Impulse);
            Debug.Log("FLY YOU FOOLS");
        }
    }
}
