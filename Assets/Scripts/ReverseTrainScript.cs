using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseTrainScript : MonoBehaviour
{
    public GameObject train;
    public GameObject[] hideCharacters;
    public Renderer[] materials;
    public Color[] colors;
    PlayerScript player;
    TriggerScene trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = FindObjectOfType<TriggerScene>();
        player = FindObjectOfType<PlayerScript>();
        if (PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 1)
        {
            train.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            foreach(GameObject a in hideCharacters)
            {
                a.SetActive(false);
            }
            for (int i = 0; i < materials.Length; i++)
            {
                materials[i].sharedMaterial.color =  colors[i];
            }
            player.UpdateDay();
            trigger.sceneName = "Day";
            PlayerPrefs.SetInt("time", 0);
            PlayerPrefs.SetInt("Teleprompt", 0);
            trigger.index = 0;
        }
        else if(PlayerPrefs.GetInt("changePos") == 1 && PlayerPrefs.GetInt("index") == 0)
        {
            train.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            foreach(Renderer ren in materials)
            {
                ren.sharedMaterial.color = Color.white;
            }
            foreach (GameObject b in hideCharacters)
            {
                b.SetActive(true);
            }
            /*foreach (MeshRenderer mat in materials)
            {
                mat.material.SetColor("_Color", Color.white);
                Debug.Log("Working");
            }*/
            trigger.sceneName = "Crossroad";
        }
        else
        {
            foreach (Renderer ren in materials)
            {
                ren.sharedMaterial.color = Color.white;
            }
        }
        PlayerPrefs.SetInt("changePos", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
