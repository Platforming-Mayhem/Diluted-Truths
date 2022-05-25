using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public AudioClip start;
    public AudioClip quit;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin(string sceneName)
    {
        audioSource.PlayOneShot(start);
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("DayCounter", 1);
        PlayerPrefs.SetInt("USB1", 0);
    }

    public void Quit()
    {
        audioSource.PlayOneShot(quit);
        Application.Quit();
    }
}
