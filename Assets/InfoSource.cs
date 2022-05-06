using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Source", menuName = "Source")]
public class InfoSource : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;
    public string[] categories;

}
