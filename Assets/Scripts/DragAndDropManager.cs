using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DragAndDropManager : MonoBehaviour
{
    [SerializeField]

    private GameObject[] expandedObjects;

    public GameObject[] slots;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
        foreach (GameObject a in expandedObjects)
        {
            a.SetActive(false);
        }
    }

    public GameObject previouslyDropped;

    public bool isSelected;

    public void Rearrange()
    {
        Dropable a = previouslyDropped.GetComponent<Dropable>();
        Dropable[] dropable = FindObjectsOfType<Dropable>();
        foreach (Dropable d in dropable)
        {
            if (d.gameObject != previouslyDropped && d.originalParent == a.originalParent)
            {
                d.index = -1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool CheckScript()
    {
        try
        {
            Dropable drop = FindObjectOfType<Dropable>();
            if (drop.choices.transform.childCount >= 3)
            {
                Debug.Log("Can submit!");
                string sequence = "";
                foreach(Dropable a in drop.choices.GetComponentsInChildren<Dropable>())
                {
                    sequence += a.name;
                }
                string[] b = sequence.Split();
                List<string> c = b.ToList();
                c.Sort();
                Debug.Log(c[0]);
                Debug.Log(c[1]);
                Debug.Log(c[2]);
                return true;
            }
            else
            {
                Debug.Log("Can't submit");
                return false;
            }
        }
        catch
        {
            Debug.Log("Error: Can't submit");
            return false;
        }
    }

    public void SubmitButton(string sceneName)
    {
        bool canSubmit = CheckScript();
        if (canSubmit)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void Expand(int index)
    {
        foreach (GameObject a in expandedObjects)
        {
            a.SetActive(false);
        }
        expandedObjects[index].SetActive(true);
    }
}
