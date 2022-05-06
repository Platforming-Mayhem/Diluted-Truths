using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 cameraBoundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lerpValue = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * speed);
        transform.position = new Vector3(lerpValue.x, transform.position.y, lerpValue.z);
    }
}
