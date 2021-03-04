﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlantControler : MonoBehaviour
{

    

    public GameObject gobj_Seed, gobj_Sprout, gobj_Flower;
    public GameObject gobj_SeedBotton;
    
    
    public bool haveSeed;

    private bool seedPlanted = false;
    public int amountWater;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        haveSeed = GameManager.flowchart.GetBooleanVariable("HaveSeed");

        if (amountWater == 1)
        {
            gobj_Seed.SetActive(false);
            gobj_Sprout.SetActive(true);
        }
        if (amountWater == 2){
            gobj_Sprout.SetActive(false);
            gobj_Flower.SetActive(true);
            GameManager.flowerPickable = true;
        }
        
        gobj_SeedBotton.SetActive(haveSeed);
        
    }
    
    void OnMouseDown()
    {
        if (GameManager.currentTool == "seed")
        {
            gobj_Seed.SetActive(true);
            GameManager.flowchart.SetBooleanVariable("HaveSeed", false);
            seedPlanted = true;
            GameManager.currentTool = "none";
            
        }

        if (GameManager.currentTool == "waterCan" && seedPlanted == true)
        {
            if (amountWater < 2)
            amountWater = amountWater + BrunnScript.amountOfWaterInCan;
            BrunnScript.amountOfWaterInCan = 0;


        }
        if (GameManager.flowerPickable == true)
        {
            amountWater = 0;
            gobj_Flower.SetActive(false);

            GameManager.flowchart.SetBooleanVariable("HaveFlower", true);
            GameManager.flowerPickable = false;
            seedPlanted = false;
            Debug.Log("Have the flower");
    }
    }
}
