using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideIfIndex : MonoBehaviour
{
    public GameObject[] objectsToHide;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Teleprompt") == 1)
        {
            foreach(GameObject a in objectsToHide)
            {
                a.SetActive(false);
            }
            PlayerPrefs.SetInt("index", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
