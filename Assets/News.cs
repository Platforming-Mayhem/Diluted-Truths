using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New News", menuName = "News")]
public class News : ScriptableObject
{
    public string title;
    public string blurb;

    public Sprite icon;
    public int ID;
    public int minDays;
    public string category;
    public string[] reportingOptions = new string[3];
    //public int[] effectStr = new int[3];
    public string source;
    //public bool[] barsAffected = new bool[3];

    public void optionSelected(int num)
    {
        switch(num)
        {
            case 1:
                // increment the global variables by whatever
                break;
            case 2:
                // increment the global variables by whatever
                break;
            case 3:
                // increment the global variables by whatever
                break;
            default:
                Debug.Log(num.ToString() + "is an incorrect selection.");
                break;
        }
    }



}
