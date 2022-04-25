using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropable : MonoBehaviour
{
    private DragAndDropManager dropManager;

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

    bool isInBox()
    {
        Vector3[] corners = new Vector3[4];
        image.rectTransform.GetWorldCorners(corners);
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
            }
        }
        else
        {
            transform.position = (Vector3)mousePosition;
        }
        if(isInBox() && Input.GetMouseButtonDown(0) && !dropManager.isSelected)
        {
            dropManager.isSelected = true;
            selected = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < dropManager.slots.Length; i++)
            {
                if((mousePosition - (Vector2)dropManager.slots[i].transform.position).magnitude <= 1.0f)
                {
                    index = i;
                }
            }
            selected = false;
            dropManager.isSelected = false;
        }
        
    }
}
