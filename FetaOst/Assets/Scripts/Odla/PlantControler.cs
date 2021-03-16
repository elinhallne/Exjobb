using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlantControler : MonoBehaviour
{

    public Plantage[] plantages;
       int i = 0;

    
  public PlantControler()
    {
        /*foreach (Plantage plantage in plantages)
        {
            plantage = new Plantage();
            plantages.Add(plantage); 
        } */
    }
    void OnMouseDown() //collider sitter på denna
    {
        plantages[i].FlowerPlanted();

        plantages[i].FlowerIsWatered();

        plantages[i].FlowerReadyToPick();
    }
    
       
}
