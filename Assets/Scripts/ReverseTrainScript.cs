using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseTrainScript : MonoBehaviour
{
    public GameObject train;
    public GameObject[] hideCharacters;
    public GameObject[] showCharacters;
    public Renderer[] materials;
    public Color[] colors;
    PlayerScript player;
    TriggerScene trigger;
    public DialogueTrigger[] diagT = new DialogueTrigger[3];
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
            foreach(GameObject c in showCharacters)
            {
                c.SetActive(true);
            }
            for (int i = 0; i < materials.Length; i++)
            {
                materials[i].sharedMaterial.color =  colors[i];
            }
            PlayerPrefs.SetInt("USB1", 0);
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
            foreach(GameObject d in showCharacters)
            {
                d.SetActive(false);
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
            foreach (GameObject b in hideCharacters)
            {
                b.SetActive(true);
            }
            foreach(GameObject d in showCharacters)
            {
                d.SetActive(false);
            }
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
