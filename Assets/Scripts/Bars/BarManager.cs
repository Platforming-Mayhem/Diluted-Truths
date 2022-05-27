using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    //Bars
    private Bar[] bars = new Bar[3];
    //Bars GUI
    //public Image[] barsGUI = new Image[3];

    void Start()
    {
        for (int i = 0; i < bars.Length; i++)
        {
            bars[i] = new Bar { amount = 0 };
            //barsGUI[i].transform.localScale = new Vector3(1.0f, bars[i].ReadAmount() / 100.0f, 1.0f);
        }
    }

    void Update()
    {
        PlayerPrefs.SetInt("Bar1", bars[0].amount);
        PlayerPrefs.SetInt("Bar2", bars[1].amount);
        PlayerPrefs.SetInt("Bar3", bars[2].amount);
    }

    public void AddAmountToBar(int index, int amount)
    {
        int tmpAmount = bars[index].ReadAmount() + amount;
        if (tmpAmount >= -100 && tmpAmount <= 100)
        {
            bars[index].AddToAmount(amount);
        }
        //barsGUI[index].transform.localScale = new Vector3(1.0f, bars[index].ReadAmount() / 100.0f, 1.0f);
    }

    public void RemoveAmountFromBar(int index, int amount)
    {
        int tmpAmount = bars[index].ReadAmount() - amount;
        if (tmpAmount >= -100 && tmpAmount <= 100)
        {
            bars[index].RemoveFromAmount(amount);
        }
        //barsGUI[index].transform.localScale = new Vector3(1.0f, bars[index].ReadAmount() / 100.0f, 1.0f);
    }

    public int CheckAmountFromBar(int index)
    {
        return bars[index].ReadAmount();
    }
}
