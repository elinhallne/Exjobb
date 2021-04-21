﻿using System.Collections;
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
    private int counter = 0;
    
    
    public Dropdown myDropdown;
    private Text[] texts;
   // private TMP_Text[] textPROs;



    // Start is called before the first frame update
    private void Start()
    {
        counter = GlobalOptionsControl.Instance.counter;
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
        UpdateText();
        SaveData();
     
        /*foreach (TMP_Text text in textPROs)
        {
            TMP_FontAsset = myFonts[counter];
        }*/

        myDropdown.onValueChanged.AddListener(delegate
        {
            myDropDownValueChangedHappened(myDropdown);
        });

    }

    private void UpdateText()
    {
        foreach (Text text in texts)
        {
            text.font = myFonts[counter];

        }
    }

    private void SaveData()
    {
        GlobalOptionsControl.Instance.counter = counter;
    }
}