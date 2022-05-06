using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OutcomeManager : MonoBehaviour
{
    public InfoSource currentIS;
    [SerializeField] InfoSource[] allIS;
    [SerializeField] GameObject[] categories;
    [SerializeField] Database db;
    private CanvasGroup newsCG;
    public int days;
    public string selectedCategory;

    // Start is called before the first frame update
    [SerializeField] News newsPiece;
    [SerializeField] GameObject[] buttons;


    public void setupUI()
    {
        int i = 0;
        foreach(GameObject category in categories)
        {
            TextMeshProUGUI title = category.transform.Find("Title").gameObject.GetComponent<TextMeshProUGUI>();

            title.text = currentIS.categories[i];
            i += 1;
            Debug.Log("Incrementing");
            Debug.Log(i);
        }
        SetButtons();
    }

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

    private void Update()
    {
          
    }
}
