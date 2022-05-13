using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseTrainScript : MonoBehaviour
{
    public GameObject train;
    TriggerScene trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = FindObjectOfType<TriggerScene>();
        if (PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 1)
        {
            train.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            trigger.sceneName = "Train";
            trigger.index = 0;
        }
        else if(PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 0)
        {
            train.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            trigger.sceneName = "Crossroad";
        }
        PlayerPrefs.SetInt("changePos", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
