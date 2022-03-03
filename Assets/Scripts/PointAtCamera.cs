using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtCamera : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.forward = Vector3.Scale(target.position - mainCamera.transform.position, Vector3.one - Vector3.right).normalized;
    }
}
