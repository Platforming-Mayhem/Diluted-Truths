using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar
{
    public int amount = 0;

    public void SetAmount(int input)
    {
        amount = input;
    }

    public void AddToAmount(int input)
    {
        amount += input;
    }

    public void RemoveFromAmount(int input)
    {
        amount -= input;
    }

    public int ReadAmount()
    {
        return amount;
    }
}
