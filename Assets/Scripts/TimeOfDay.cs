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
        if(PlayerPrefs.GetInt("Teleprompt") == 1)
        {
            onOrOff = true;
        }
        else
        {
            onOrOff = false;
        }
    }

    public bool onOrOff;

    // Update is called once per frame
    void Update()
    {
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
