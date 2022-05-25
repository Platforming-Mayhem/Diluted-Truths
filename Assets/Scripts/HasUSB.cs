using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasUSB : MonoBehaviour
{
    public TriggerScene trig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("USB1") == 0)
        {
            trig.enabled = false;
        }
        else if (PlayerPrefs.GetInt("USB1") == 1)
        {
            trig.enabled = true;
        }
    }
}
