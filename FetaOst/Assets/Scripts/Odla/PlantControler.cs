using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlantControler : MonoBehaviour
{

    public Plantage[] plantages;
    public Flower[] flowers;
    int i = 0;

    
  public PlantControler()
    {
        /*foreach (Plantage plantage in plantages)
        {
            plantage = new Plantage();
            plantages.Add(plantage); 
        } */
    }
    void OnMouseDown()
    {
        plantages[i].FlowerPlanted(flowers[0]);

        plantages[i].FlowerIsWatered();

        plantages[i].FlowerReadyToPick();
    }
    
       
}
