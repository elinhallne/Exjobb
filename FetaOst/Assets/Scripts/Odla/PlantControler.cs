using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlantControler : MonoBehaviour
{
   [SerializeField]
    private Plantage plantages;
    
    
     void OnMouseDown() //collider sitter på denna
    {
        plantages.FlowerPlanted();

        plantages.FlowerIsWatered();

        plantages.FlowerReadyToPick();
    }
    
       
}
