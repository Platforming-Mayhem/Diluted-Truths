using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class LiteDialogueManager : MonoBehaviour
{
    [SerializeField] public DialogueVariables dialogueVariables;
    [SerializeField] private TextAsset globalsvar;
    // Start is called before the first frame update
    void Start()
    {
        dialogueVariables = new DialogueVariables(globalsvar);
        Debug.Log(dialogueVariables);
    }
    public void SetVariableState(string variableName, Ink.Runtime.Object variableValue)
    {
        Debug.Log(variableName);
        Debug.Log(variableValue);
        if (dialogueVariables.variables.ContainsKey(variableName))
        {
            dialogueVariables.variables.Remove(variableName);
            dialogueVariables.variables.Add(variableName, variableValue);
            dialogueVariables.SaveVariables();
        }
        else
        {
            Debug.LogWarning("Tried to update variable that wasn't initialized by globals.ink: " + variableName);
        }
    }
}
