using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseTrainScript : MonoBehaviour
{
    public GameObject train;
    public GameObject[] hideCharacters;
    public Material[] materials;
    public Color[] colors;
    TriggerScene trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = FindObjectOfType<TriggerScene>();
        if (PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 1)
        {
            train.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            foreach(GameObject a in hideCharacters)
            {
                a.SetActive(false);
            }
            for (int i = 0; i < materials.Length - 1; i++)
            {
                materials[i].color = colors[i];
                Debug.Log("Working");
            }
            trigger.sceneName = "Train";
            trigger.index = 0;
        }
        else if(PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 0)
        {
            train.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            foreach (GameObject b in hideCharacters)
            {
                b.SetActive(true);
            }
            foreach (Material mat in materials)
            {
                mat.color = new Color(1.0f, 1.0f, 1.0f);
                Debug.Log("Working");
            }
            trigger.sceneName = "Crossroad";
        }
        PlayerPrefs.SetInt("changePos", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
