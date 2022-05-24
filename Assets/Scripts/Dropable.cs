using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropable : MonoBehaviour
{
    private DragAndDropManager dropManager;

    public GameObject choices;

    public int index = -1;

    private bool selected;

    private Vector3 origin;

    [SerializeField]
    private MeshRenderer image;

    public Transform originalParent;

    public int originalChildCount;

    // Start is called before the first frame update
    void Start()
    {
        origin = image.transform.position;
        dropManager = FindObjectOfType<DragAndDropManager>();
        originalParent = image.transform.parent;
        originalChildCount = originalParent.childCount;
    }

    bool isInBox(Bounds bounds)
    {
        Debug.Log(mousePosition);
        Vector3 min = bounds.min;
        Vector3 max = bounds.max;
        Debug.Log("min: " + min);
        Debug.Log("max: " + max);
        if (mousePosition.x >= min.x && mousePosition.x <= max.x && mousePosition.y >= min.y && mousePosition.y <= max.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (!selected)
        {
            if(index == -1)
            {
                image.transform.position = Vector3.Lerp(image.transform.position, origin, Time.deltaTime * 5.0f);
                dropManager.previouslyDropped = null;
                if((transform.position - origin).magnitude <= 1.0f)
                {
                    image.transform.SetParent(originalParent);
                    image.transform.position = origin;
                }
            }
            else
            {
                image.transform.position = Vector3.Scale(dropManager.slots[index].transform.position, Vector3.right + Vector3.up) + Vector3.forward * origin.z;
                dropManager.slots[index].transform.SetParent(choices.transform);
                image.transform.SetParent(dropManager.slots[index].transform);
                if (originalParent.childCount < originalChildCount - 1)
                {
                    dropManager.previouslyDropped = gameObject;
                    dropManager.Rearrange();
                }
            }
        }
        else
        {
            image.transform.position = (Vector3)mousePosition + Vector3.forward * origin.z;
            image.transform.SetParent(originalParent.parent);
        }
        if (dropManager.previouslyDropped == null)
        {
            if (isInBox(image.bounds) && Input.GetMouseButtonDown(0) && !dropManager.isSelected)
            {
                dropManager.isSelected = true;
                selected = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                if (selected)
                {
                    for (int i = 0; i < dropManager.slots.Length; i++)
                    {
                        Bounds temp = dropManager.slots[i].GetComponent<MeshRenderer>().bounds;
                        if (isInBox(temp) && dropManager.slots[i].transform.childCount == 0)
                        {
                            index = i;
                            dropManager.audioSource.PlayOneShot(dropManager.pinSFX);
                            break;
                        }
                        else
                        {
                            index = -1;
                        }
                    }
                }
                selected = false;
                dropManager.isSelected = false;
            }
        }
        else
        {
            index = -1;
            selected = false;
            dropManager.isSelected = false;
        }
    }
}
