using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextColour : MonoBehaviour
{
    private Text[] textsInGame;
    private GameObject[] bakrundInGame;
    [SerializeField]
    private TMP_Dropdown myDropDown;

    //private List<GameObject> goWithTag;

    private int textColourCount = 0;
    private Color currentColour = Color.white;

   
    void Start()
    {
        //goWithTag = new List<GameObject>();

        //AddGOToList();
       

        textColourCount = GlobalOptionsControl.Instance.textColourCount;
        currentColour = GlobalOptionsControl.Instance.currentColour;

        textsInGame = Resources.FindObjectsOfTypeAll<Text>();
        myDropDown = GetComponent<TMP_Dropdown>();


        /*bakrundInGame = GameObject.FindGameObjectsWithTag("Say Dialog");
        UpdateBakrundColour();*/
        UpdateTextColour();

        /*foreach (Text text in textsInGame)
        {
            int i = 0;
            Text goTextComp = goWithTag[i].GetComponent<Text>();

            if (text == goTextComp)
            {

            }
            i++;
        }*/






    }

    // Update is called once per frame
    void Update()
    {
        

        myDropDown.onValueChanged.AddListener(delegate
        {
            MyDropDownValueChangedHappened(myDropDown);
            UpdateTextColour();
            SaveData();

        });
    }
    public void MyDropDownValueChangedHappened(TMP_Dropdown sender)
    {
        Debug.Log("You have selected this: " + sender.value);
        switch (sender.value)
        {
            case 0:
                textColourCount = 0;
                currentColour = Color.white;

                break;
            case 1:
                textColourCount = 1;
                currentColour = Color.blue;

                break;
            case 2:
                textColourCount = 2;
                currentColour = Color.yellow;

                break;
        }
    }

    private void UpdateTextColour()
    {
               
        foreach(Text text in textsInGame)
        {
            text.color = currentColour;
        }
    }

   /* private void UpdateBakrundColour()
    {
        Image backrundColur = options[textColourCount].GetComponentInChildren<Image>();

        foreach(GameObject gameObject in bakrundInGame)
        {
            Image image = gameObject.GetComponent<Image>();
            image.color = backrundColur.color;
        }

    }*/
    public void SaveData()
    {
        GlobalOptionsControl.Instance.textColourCount = textColourCount;
        GlobalOptionsControl.Instance.currentColour = currentColour;
    }

    /*private void AddGOToList()
    {
        GameObject[] toAdd;
        toAdd = GameObject.FindGameObjectsWithTag("MenyText");

        foreach (GameObject gameObject in toAdd)
            goWithTag.Add(gameObject);
    }*/
}
