using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    [SerializeField]
    private GameObject day;
    [SerializeField]
    private GameObject night;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool onOrOff;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (onOrOff)
            {
                onOrOff = false;
            }
            else
            {
                onOrOff = true;
            }
        }
        if (onOrOff)
        {
            day.SetActive(false);
            night.SetActive(true);
        }
        else
        {
            day.SetActive(true);
            night.SetActive(false);
        }
    }
}
