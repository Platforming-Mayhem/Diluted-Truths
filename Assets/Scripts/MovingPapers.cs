using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPapers : MonoBehaviour
{
    public float force = 100.0f;
    public AudioClip paperRussle;
    private AudioSource paper;
    Rigidbody rb;
    Collider col;

    bool active;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        active = false;
        paper = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude == 0.0f && active)
        {
            col.isTrigger = true;
            rb.useGravity = false;
            active = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        active = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.AddForce(Vector3.Scale(transform.position - other.transform.position, Vector3.one - Vector3.up) * force, ForceMode.Impulse);
            paper.pitch = Random.Range(1.0f, 3.0f);
            paper.PlayOneShot(paperRussle);
            col.isTrigger = false;
            rb.useGravity = true;
            StartCoroutine("Wait");
        }
    }
}
