using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public NewsDatabase newsDB;
    [SerializeField]
    List<int> bannedIDs = new List<int>();
    public DialogueManager diagM;
    public BarManager barM;
    

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

    public void CalculateBarChanges(Dropable[] dropList)
    {
        foreach(News newsP in newsDB.allNews)
        {
            foreach(Dropable drop in dropList)
            {
                if(drop.ID == newsP.ID)
                {
                    barM.AddAmountToBar(0, newsP.effectStr[0]);
                    barM.AddAmountToBar(1, newsP.effectStr[1]);
                    barM.AddAmountToBar(2, newsP.effectStr[2]);

                    int govD = barM.CheckAmountFromBar(0);
                    int pubD = barM.CheckAmountFromBar(1);
                    int pubO = barM.CheckAmountFromBar(2);

                    Ink.Runtime.Object obj1 = new Ink.Runtime.IntValue(govD);
                    Ink.Runtime.Object obj2 = new Ink.Runtime.IntValue(pubD);
                    Ink.Runtime.Object obj3 = new Ink.Runtime.IntValue(pubO);
                }
            }
        }
    }
}
