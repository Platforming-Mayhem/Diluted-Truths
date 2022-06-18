using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCManager : MonoBehaviour
{
    [SerializeField] public TextAsset diag1;
    [SerializeField] public TextAsset diag2;
    [SerializeField] public TextAsset diag3;
    [SerializeField] ReverseTrainScript RTS;
    [SerializeField] PlayerScript ps;
    [SerializeField] int i = 0;

    public void Awake(){
        DontDestroyOnLoad(gameObject);
        Debug.Log("Yadda Yadda Yadda");
        Debug.Log(SceneManager.GetActiveScene().name);

        // needs to check if hes on his way back
        if(SceneManager.GetActiveScene().name == "Train")
        {
            Debug.Log("Setting Dialogue, it's 2016 drill.");
            RTS = FindObjectOfType<ReverseTrainScript>();
            ps = FindObjectOfType<PlayerScript>();
            SetDialogue();
        }
    }

    private void Start(){
        Debug.Log("Testing Testing 123");
    }




    public void SetDialogue(){
        RTS = RTS = FindObjectOfType<ReverseTrainScript>();
        ps = FindObjectOfType<PlayerScript>();
        Debug.Log(ps.dayCounter);
        switch (ps.dayCounter){
            case 1:
                foreach(GameObject g in RTS.showD1)
                {   
                    Debug.Log(g);
                    Debug.Log("Found a gameobject.");
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    Debug.Log(dt);
                    switch(i){
                        case 1:
                            Debug.Log(diag1);
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            Debug.Log(diag2);
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            Debug.Log(diag3);
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
            case 2:
                foreach(GameObject g in RTS.showD2)
                {   
                    Debug.Log(g);
                    Debug.Log("Found a gameobject.");
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    Debug.Log(dt);
                    switch(i){
                        case 1:
                            Debug.Log(diag1);
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            Debug.Log(diag2);
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            Debug.Log(diag3);
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
            case 3:
                foreach(GameObject g in RTS.showD3)
                {   
                    Debug.Log(g);
                    Debug.Log("Found a gameobject.");
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    Debug.Log(dt);
                    switch(i){
                        case 1:
                            Debug.Log(diag1);
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            Debug.Log(diag2);
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            Debug.Log(diag3);
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
            default:
                Debug.Log("Something broke, what?");
                break;
        }

        i = 0;
        Destroy(this.gameObject);
    }
}
