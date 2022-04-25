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
        foreach(GameObject a in expandedObjects)
        {
            a.SetActive(false);
        }
    }

    public bool isSelected;

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
