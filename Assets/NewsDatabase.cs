using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Database")]
public class NewsDatabase : ScriptableObject
{
    public List<News> allNews;
}
