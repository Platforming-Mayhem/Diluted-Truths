using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideIfIndex : MonoBehaviour
{
    public GameObject[] objectsToHide;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("index") == 1)
        {
            foreach(GameObject a in objectsToHide)
            {
                a.SetActive(false);
            }
            PlayerPrefs.SetInt("Teleprompt", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
