using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTravel : MonoBehaviour
{
    public GameObject train;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Teleprompt") == 0)
        {
            train.GetComponent<MeshCollider>().isTrigger = false;
            train.GetComponent<TriggerScene>().enabled = false;
        }
        else
        {
            train.GetComponent<MeshCollider>().isTrigger = true;
            train.GetComponent<TriggerScene>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
