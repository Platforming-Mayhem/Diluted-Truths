using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public NewsDatabase newsDB;

    //gets news source based on the inputted source and current days alongside the selected categoryu
    public News GetSpecifiedNews(string source, int days, string category)
    {
        List<News> potentialNews = new List<News>();
        Debug.Log(source);
        foreach(News news in newsDB.allNews)
        {
            if(news.source == source && news.minDays <= days && news.category == category)
            {
                Debug.Log("Working");
                Debug.Log(news);
                potentialNews.Add(news);
            }
        }
        if(potentialNews.Count <= 0 )
        {
            return(null);
        }
        int indexToSelect = Random.Range(0, potentialNews.Count);
        return(potentialNews[indexToSelect]);
    }
}
