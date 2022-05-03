using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeadlinesScript : MonoBehaviour
{
    public TMP_Text text;

    public NewsReportInfo news;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
        foreach (string a in news.information)
        {
            text.text += a + '\n';
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
