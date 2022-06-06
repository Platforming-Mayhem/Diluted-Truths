using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowDayNumber : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        int dayCounter = PlayerPrefs.GetInt("DayCounter");
        text.text = "Day "+ dayCounter.ToString();
        if(dayCounter >= 4)
        {
            FindObjectOfType<TimedChangeScene>().sceneName = "EndScene";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
