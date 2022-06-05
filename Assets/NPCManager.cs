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

    public void Awake(){
        DontDestroyOnLoad(gameObject);


        // needs to check if hes on his way back
        if(SceneManager.GetActiveScene().name == "Train")
        {
            Debug.Log("Setting Dialogue, it's 2016 drill.");
            RTS = FindObjectOfType<ReverseTrainScript>();
            ps = FindObjectOfType<PlayerScript>();
            SetDialogue();
        }
    }

    




    public void SetDialogue(){
        int i = 0;
        switch (ps.dayCounter){
            case 1:
                foreach(GameObject g in RTS.showD1)
                {   
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    switch(i){
                        case 1:
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
            case 2:
                foreach(GameObject g in RTS.showD2)
                {   
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    switch(i){
                        case 1:
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
            case 3:
                foreach(GameObject g in RTS.showD3)
                {   
                    i += 1;
                    DialogueTrigger dt;
                    dt = g.GetComponent<DialogueTrigger>();
                    switch(i){
                        case 1:
                            dt.SetInky(diag1);
                            break;
                        case 2:
                            dt.SetInky(diag2);
                            break;
                        case 3:
                            dt.SetInky(diag3);
                            break;
                    }
                }
                break;
        }

        i = 0;
        Destroy(this.gameObject);
    }
}
