using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public NewsDatabase newsDB;
    [SerializeField]
    List<int> bannedIDs = new List<int>();
    public LiteDialogueManager diagM;
    public BarManager barM;
    public NPCManager npcM;
    private DialogueVariables dialogueVariables;

    private void Awake()
    {
        diagM = FindObjectOfType<LiteDialogueManager>();
        barM = FindObjectOfType<BarManager>();
        npcM = FindObjectOfType<NPCManager>();
    }
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
        return(potentialNews[indexToSelect]);
    }

    int i = 0;
    public void CalculateBarChanges(Dropable[] dropList)
    {
        foreach(News newsP in newsDB.allNews)
        {
            foreach(Dropable drop in dropList)
            {
                if(drop.ID == newsP.ID)
                {
                    Debug.Log("Found a match.");
                    barM.AddAmountToBar(0, newsP.effectStr[0]);
                    barM.AddAmountToBar(1, newsP.effectStr[1]);
                    barM.AddAmountToBar(2, newsP.effectStr[2]);

                    int govD = barM.CheckAmountFromBar(0);
                    int pubU = barM.CheckAmountFromBar(1);
                    int pubO = barM.CheckAmountFromBar(2);

                    Ink.Runtime.Object obj1 = new Ink.Runtime.IntValue(govD);
                    Ink.Runtime.Object obj2 = new Ink.Runtime.IntValue(pubU);
                    Ink.Runtime.Object obj3 = new Ink.Runtime.IntValue(pubO);
                    //Debug.Log("Government Distrust Values");
                    //Debug.Log(newsP.effectStr[0]);
                    //Debug.Log(govD);
                    //Debug.Log(obj1);
                    //Debug.Log(barM.CheckAmountFromBar(0));

                    diagM.SetVariableState("gov_distrust", obj1);
                    diagM.SetVariableState("public_unrest", obj2);
                    diagM.SetVariableState("public_opinion", obj3);

                    i += 1;

                    switch(i){
                        case 1:
                            npcM.diag1 = newsP.relatedDiag;
                            break;
                        case 2:
                            npcM.diag2 = newsP.relatedDiag;
                            break;
                        case 3:
                            npcM.diag3 = newsP.relatedDiag;
                            break;
                        default:
                            Debug.Log("Outside of 3");
                            break;
                    }
                }
            }
        }
    }
}
