using System.Collections;
using System.Collections.Generic;
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

    public void Expand(int index)
    {
        foreach (GameObject a in expandedObjects)
        {
            a.SetActive(false);
        }
        expandedObjects[index].SetActive(true);
    }
}
