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
        if (Input.GetMouseButtonDown(0))
        {
            AddAmountToBar(0, 10);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RemoveAmountFromBar(0, 10);
        }
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
}
