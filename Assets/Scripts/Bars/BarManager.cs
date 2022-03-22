using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public Bar[] bars = new Bar[3];
    public Image[] barsGUI = new Image[3];
    // Start is called before the first frame update
    void Start()
    {
        foreach(Bar bar in bars)
        {
            bar.SetAmount(0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
