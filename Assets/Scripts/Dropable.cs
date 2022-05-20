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

    private Image image;

    public Transform originalParent;

    public int originalChildCount;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        dropManager = FindObjectOfType<DragAndDropManager>();
        image = GetComponent<Image>();
        originalParent = transform.parent;
        originalChildCount = originalParent.childCount;
    }

    bool isInBox(Image src)
    {
        Vector3[] corners = new Vector3[4];
        if (mousePosition.x >= corners[0].x && mousePosition.x <= corners[2].x && mousePosition.y >= corners[0].y && mousePosition.y <= corners[2].y)
        {
            Debug.Log("Yes");
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
                transform.position = Vector3.Lerp(transform.position, origin, Time.deltaTime * 5.0f);
                dropManager.previouslyDropped = null;
                if((transform.position - origin).magnitude <= 1.0f)
                {
                    transform.SetParent(originalParent);
                    transform.position = origin;
                }
            }
            else
            {
                transform.position = dropManager.slots[index].transform.position;
                transform.SetParent(choices.transform);
                if (originalParent.childCount < originalChildCount - 1)
                {
                    dropManager.previouslyDropped = gameObject;
                    dropManager.Rearrange();
                }
            }
        }
        else
        {
            transform.position = (Vector3)mousePosition;
            transform.SetParent(originalParent.parent);
        }
        if (dropManager.previouslyDropped == null)
        {
            if (isInBox(image) && Input.GetMouseButtonDown(0) && !dropManager.isSelected)
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
                        Image temp = dropManager.slots[i].GetComponent<Image>();
                        if (isInBox(temp) && dropManager.slots[i].transform.childCount == 0)
                        {
                            index = i;
                            break;
                        }
                        else if (!isInBox(temp))
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
