using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OutcomeManager : MonoBehaviour
{
    [SerializeField] private GameObject[] categories;
    [SerializeField] Database db;
    [SerializeField] private int days;
    [SerializeField] private string unqiueCate;
    [SerializeField] private GameObject[] buttonsCategory1;
    [SerializeField] private GameObject[] buttonsCategory2;
    [SerializeField] private GameObject[] buttonsCategory3;
    [SerializeField] private News newsPiece;
    [SerializeField] private PlayerScript ps;



    void Start()
    {
        days = PlayerPrefs.GetInt("DayCounter");
        switch (days)
        {
            case 1:
                unqiueCate = "Economy";
                break;
            case 2:
                unqiueCate = "Healthcare";
                break;
            case 3:
                unqiueCate = "Entertainment";
                break;
        }


        int i = 0;
        foreach(GameObject category in categories)
        {
            TextMeshProUGUI title = category.transform.Find("Title").gameObject.GetComponent<TextMeshProUGUI>();
            switch(i)
            {
                case 0:
                    title.text = "War";
                    break;
                case 1:
                    title.text = "Refugees";
                    break;
                case 2:
                    switch(days)
                    {
                        case 1:
                            title.text = "Economy";
                            break;
                        case 2:
                            title.text = "Healthcare";
                            break;
                        case 3:
                            title.text = "Entertainment";
                            break;
                        default:
                            Debug.Log("Days not up to 3.");
                            title.text = "Broken!";
                            break;
                    }
                    break;
                default:
                    Debug.Log("Abnormal I counter.");
                    break;
            }
            i += 1;
        }

        SetButtons1();
        SetButtons2();
        SetButtons3();
    }

    public void SetButtons1()
    {
        foreach (GameObject button in buttonsCategory1)
        {
            newsPiece = db.GetSpecifiedNews(days, "War");

            GameObject currentButton = button.transform.Find("titleText").gameObject;

            TextMeshProUGUI title = currentButton.GetComponent<TextMeshProUGUI>();

            currentButton.transform.parent.parent.GetComponent<Dropable>().ID = newsPiece.ID;

            if (!title)
            {
                Debug.Log("Broken Buttons.");
                return;
            }
            
            title.text = newsPiece.title;
        }

    }

    public void SetButtons2()
    {
        foreach (GameObject button in buttonsCategory2)
        {
            newsPiece = db.GetSpecifiedNews(days, "Refugees");
            GameObject currentButton = button.transform.Find("titleText").gameObject;

            TextMeshProUGUI title = currentButton.GetComponent<TextMeshProUGUI>();

            currentButton.transform.parent.parent.GetComponent<Dropable>().ID = newsPiece.ID;
            if (!title)
            {
                Debug.Log("Broken Buttons.");
                return;
            }
            title.text = newsPiece.title;
        }

    }

    public void SetButtons3()
    {
        foreach (GameObject button in buttonsCategory3)
        {
            newsPiece = db.GetSpecifiedNews(days, unqiueCate);
            GameObject currentButton = button.transform.Find("titleText").gameObject;

            TextMeshProUGUI title = currentButton.GetComponent<TextMeshProUGUI>();

            currentButton.transform.parent.parent.GetComponent<Dropable>().ID = newsPiece.ID;
            if (!title)
            {
                Debug.Log("Broken Buttons.");
                return;
            }
            title.text = newsPiece.title;
        }

    }
     /*
    public void sendBack()
    {
        SceneManager.LoadScene("Office");
    }

    #region unfinished and unrefinded UI stuff
    public void loadPiece1()
    {
        currentIS = allIS[0];
        selectedCategory = currentIS.categories[0];
        Debug.Log("Setting Up");
        setupUI();
    }

    public void loadPiece2()
    {
        currentIS = allIS[1];
        selectedCategory = currentIS.categories[1];
        setupUI();
    }

    public void loadPiece3()
    {
        currentIS = allIS[2];
        selectedCategory = currentIS.categories[2];
        setupUI();
    }



    public void SetButtons()
    {
        foreach (GameObject button in buttons)
        {
            newsPiece = db.GetSpecifiedNews(currentIS.name, days, selectedCategory);
            Debug.Log(newsPiece);

            TextMeshProUGUI title = button.transform.Find("titleText").gameObject.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI desc = button.transform.Find("descText").gameObject.GetComponent<TextMeshProUGUI>();

            Debug.Log(title);

            if (!title || !desc)
            {
                return;
            }

            title.text = newsPiece.title;
            desc.text = newsPiece.blurb;

        }

    }

    public void changeCategory1()
    {
        selectedCategory = currentIS.categories[0];
        SetButtons();
    }

    public void changeCategory2()
    {
        selectedCategory = currentIS.categories[1];
        SetButtons();
    }

    public void changeCategory3()
    {
        selectedCategory = currentIS.categories[2];
        SetButtons();
    }
    #endregion
     */
    private void Update()
    {
          
    }
}
