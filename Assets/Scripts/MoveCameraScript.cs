using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetPlayerPosition = Vector3.Scale(player.position, transform.right) + Vector3.Scale(transform.position, transform.up + transform.forward);
        transform.position = Vector3.Lerp(transform.position, offsetPlayerPosition, Time.deltaTime * speed);
    }
}
