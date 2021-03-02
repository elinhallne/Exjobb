using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControler : MonoBehaviour
{
    public GameObject gobj_Seed, gobj_Sprout, gobj_Flower;
    public GameObject gobj_SeedBotton;

    private bool seedPlanted = false;
    public int amountWater;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(amountWater == 1)
        {
            gobj_Seed.SetActive(false);
            gobj_Sprout.SetActive(true);
        }
        if (amountWater == 2){
            gobj_Sprout.SetActive(false);
            gobj_Flower.SetActive(true);
        }

    }
    
    void OnMouseDown()
    {
        if (GameManager.currentTool == "seed")
        {
            gobj_Seed.SetActive(true);
            seedPlanted = true;
            GameManager.currentTool = "none";
            gobj_SeedBotton.SetActive(false);
        }

        if (GameManager.currentTool == "waterCan" && seedPlanted == true)
        {
            if (amountWater < 2)
            amountWater++;
                
        }
    }
}
