using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropable : MonoBehaviour
{
    private DragAndDropManager dropManager;

    [SerializeField]
    private int index = -1;

    private bool selected;

    private Vector3 origin;

    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        dropManager = FindObjectOfType<DragAndDropManager>();
        image = GetComponent<Image>();
    }

    bool isInBox(Image src)
    {
        Vector3[] corners = new Vector3[4];
        src.rectTransform.GetWorldCorners(corners);
        if (mousePosition.x >= corners[0].x && mousePosition.x <= corners[2].x && mousePosition.y >= corners[0].y && mousePosition.y <= corners[2].y)
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
                transform.position = origin;
            }
            else
            {
                transform.position = dropManager.slots[index].transform.position;
                transform.SetParent(dropManager.slots[index].transform);
            }
        }
        else
        {
            transform.position = (Vector3)mousePosition;
            transform.SetParent(dropManager.transform);
        }
        if(isInBox(image) && Input.GetMouseButtonDown(0) && !dropManager.isSelected)
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
                    if (isInBox(dropManager.slots[i].GetComponent<Image>()) && dropManager.slots[i].transform.childCount == 0)
                    {
                        index = i;
                        break;
                    }
                    else if (!isInBox(dropManager.slots[i].GetComponent<Image>()))
                    {
                        index = -1;
                    }
                }
            }
            selected = false;
            dropManager.isSelected = false;
        }
    }
}
