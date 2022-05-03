using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Info", menuName = "ScriptableObjects/NewsReportInfo", order = 1)]
public class NewsReportInfo : ScriptableObject
{
    public List<string> information = new List<string>();
}
