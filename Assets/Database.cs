using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public NewsDatabase newsDB;
    List<int> bannedIDs = new List<int>();
    

    //gets news source based on the inputted source and current days alongside the selected categoryu
    public News GetSpecifiedNews(int days, string category)
    {
        List<News> potentialNews = new List<News>();
        foreach(News news in newsDB.allNews)
        {
            if(news.minDays == days && news.category == category)
            {
                if(!bannedIDs.Contains(news.ID))
                {
                    potentialNews.Add(news);
                } 
            }
        }
        if(potentialNews.Count <= 0 )
        {
            return(null);
        }
        int indexToSelect = Random.Range(0, potentialNews.Count);
        bannedIDs.Add(potentialNews[indexToSelect].ID);
        foreach( int x in bannedIDs){
            Debug.Log(x.ToString());
        }
        return(potentialNews[indexToSelect]);
    }
}
