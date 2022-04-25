using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject[] expandedObjects;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject a in expandedObjects)
        {
            a.SetActive(false);
        }
    }

    bool selected;

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < GameObject.FindGameObjectsWithTag("Dragable").Length; i++)
        {
            GameObject a = GameObject.FindGameObjectsWithTag("Dragable")[i];
            if (a.activeInHierarchy)
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                float range = ((Vector2)(a.transform.position - mousePosition)).magnitude;
                if (range <= 1.0f && Input.GetMouseButtonDown(0))
                {
                    selected = true;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    selected = false;
                }
                if (selected)
                {
                    a.transform.position = Vector3.Scale(mousePosition, Vector3.one - Vector3.forward);
                }
                else
                {

                }
            }
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
