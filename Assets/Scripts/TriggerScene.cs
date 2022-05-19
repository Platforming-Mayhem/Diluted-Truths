using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerScene : MonoBehaviour
{
    public Animator anim;

    public string sceneName;

    public bool changePosition = false;

    public int index;
    // Start is called before the first frame update
    void Start()
    {
        anim = FindObjectOfType<PlayerScript>().gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
        if (changePosition)
        {
            PlayerPrefs.SetInt("index", index);
            PlayerPrefs.SetInt("changePos", 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.EGUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.enabled = false;
                FindObjectOfType<TriggerRedirect>().trigger = this;
                anim.SetTrigger("FadeOut");
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.EGUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.enabled = false;
                FindObjectOfType<TriggerRedirect>().trigger = this;
                anim.SetTrigger("FadeOut");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.EGUI.SetActive(false);
        }
    }
}