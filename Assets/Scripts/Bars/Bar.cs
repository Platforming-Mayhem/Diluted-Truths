using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar
{
    private float amount;

    public void SetAmount(float input)
    {
        amount = input;
    }

    public void AddToAmount(float input)
    {
        amount += input;
    }

    public void RemoveFromAmount(float input)
    {
        amount -= input;
    }
}
