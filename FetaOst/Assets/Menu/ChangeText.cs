using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using System;
using TMPro;


public class ChangeText : MonoBehaviour
{
    [SerializeField]
    private Font[] myFonts;
    private Text text;
   // private TMP_Text textPRO;
    private int counter;
    public Font fonts;
    public GameObject button;
    private Button mybutton;
    public Dropdown myDropdown;
    int myDropdownValue;
    private Text[] texts;
   // private TMP_Text[] textPROs;



    // Start is called before the first frame update
    private void Start()
    {
        //text = GetComponent<Text>();
        counter = 0;
        //text.font = myFonts[counter];
        //GetComponent<all text>
        myDropdown = GetComponent<Dropdown>();


        texts = Resources.FindObjectsOfTypeAll<Text>();
        //textPROs = Resources.FindObjectsOfTypeAll<TMP_Text>(); 
       /* foreach (Text text in texts)
        {
            //text.font = fonts;
            text.font = myFonts[counter];
        }

        myDropdown.onValueChanged.AddListener(delegate
        {
            myDropDownValueChangedHappened(myDropdown);
        });*/

    }

    public void myDropDownValueChangedHappened(Dropdown sender)
    {
        Debug.Log("You have selected this: " + sender.value);
        switch(sender.value)
        {
            case 0:
                counter = 0;
                break;
            case 1:
                counter = 1;
                break;
            case 2:
                counter = 2;
                break;
        }
    }


    // Update is called once per frame
    private void Update()
    {
        /*if (mybutton && Input.GetButtonDown(mybutton.ToString()))
        {
            counter += 1;
            if (counter > 2)
                counter = 0;
            text.font = myFonts[counter];
        }
        myDropdownValue = myDropdown.value;*/
        foreach (Text text in texts)
        {
            //text.font = fonts;
            text.font = myFonts[counter];
            
        }
        /*foreach (TMP_Text text in textPROs)
        {
            TMP_FontAsset = myFonts[counter];
        }*/

        myDropdown.onValueChanged.AddListener(delegate
        {
            myDropDownValueChangedHappened(myDropdown);
        });

    }
}