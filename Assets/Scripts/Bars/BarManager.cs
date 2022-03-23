using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    private Bar[] bars = new Bar[3];
    public Image[] barsGUI = new Image[3];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < bars.Length; i++)
        {
            bars[i] = new Bar { amount = 0 };
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bars.Length; i++)
        {
            barsGUI[i].transform.localScale = new Vector3(1.0f, bars[i].ReadAmount() / 100.0f, 1.0f);
        }
        if (Input.GetMouseButtonDown(0) && bars[0].ReadAmount() < 100)
        {
            AddAmountToBar(0, 10);
        }
        if (Input.GetMouseButtonDown(1) && bars[1].ReadAmount() < 100)
        {
            AddAmountToBar(1, 10);
        }
        if (Input.GetMouseButtonDown(2) && bars[2].ReadAmount() < 100)
        {
            AddAmountToBar(2, 10);
        }
    }

    public void AddAmountToBar(int index, uint amount)
    {
        bars[index].AddToAmount(amount);
    }

    public void RemoveAmountFromBar(int index, uint amount)
    {
        bars[index].RemoveFromAmount(amount);
    }
}
