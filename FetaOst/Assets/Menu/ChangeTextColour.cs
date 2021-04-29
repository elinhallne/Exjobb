using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColour : MonoBehaviour
{
    private Text[] textsInGame;
    private GameObject[] bakrundInGame;
    private Dropdown myDropDown;

    private List<GameObject> goWithTag;

    private int textColourCount = 0;

    [SerializeField]
    private GameObject[] options;

    void Start()
    {
        goWithTag = new List<GameObject>();

        AddGOToList();
       

        textColourCount = GlobalOptionsControl.Instance.textColourCount;

        textsInGame = Resources.FindObjectsOfTypeAll<Text>();
        myDropDown  = GetComponent<Dropdown>();

        bakrundInGame = GameObject.FindGameObjectsWithTag("Say Dialog");
        UpdateBakrundColour();
        UpdateTextColour();

        foreach (Text text in textsInGame)
        {
            int i = 0;
            Text goTextComp = goWithTag[i].GetComponent<Text>();

            if (text == goTextComp)
            {

            }
            i++;
        }






    }

    // Update is called once per frame
    void Update()
    {
        myDropDown.onValueChanged.AddListener(delegate
        {
            MyDropDownValueChangedHappened(myDropDown);
            UpdateTextColour();
            UpdateBakrundColour();
            SaveData();
        });
    }
    public void MyDropDownValueChangedHappened(Dropdown sender)
    {
        Debug.Log("You have selected this: " + sender.value);
        switch (sender.value)
        {
            case 0:
                textColourCount = 0;

                break;
            case 1:
                textColourCount = 1;

                break;
            case 2:
                textColourCount = 2;

                break;
        }
    }

    private void UpdateTextColour()
    {
        Text theTextObjcet = options[textColourCount].GetComponent<Text>();
        
        foreach(Text text in textsInGame)
        {
            text.color = theTextObjcet.color;
        }
    }

    private void UpdateBakrundColour()
    {
        Image backrundColur = options[textColourCount].GetComponentInChildren<Image>();

        foreach(GameObject gameObject in bakrundInGame)
        {
            Image image = gameObject.GetComponent<Image>();
            image.color = backrundColur.color;
        }

    }
    public void SaveData()
    {
        GlobalOptionsControl.Instance.textColourCount = textColourCount;
    }

    private void AddGOToList()
    {
        GameObject[] toAdd;
        toAdd = GameObject.FindGameObjectsWithTag("MenyText");

        foreach (GameObject gameObject in toAdd)
            goWithTag.Add(gameObject);
    }
}
