using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("DayCounter", 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
