using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToBigman : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.FGUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("F"))
            {
                PlayerPrefs.SetInt("USB1", 1);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.FGUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("F"))
            {
                PlayerPrefs.SetInt("USB1", 1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();
            player.FGUI.SetActive(false);
        }
    }
}
