using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar
{
    public uint amount = 0;

    public void SetAmount(uint input)
    {
        amount = input;
    }

    public void AddToAmount(uint input)
    {
        amount += input;
    }

    public void RemoveFromAmount(uint input)
    {
        amount -= input;
    }

    public uint ReadAmount()
    {
        return amount;
    }
}
