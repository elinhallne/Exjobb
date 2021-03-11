using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlantControler : MonoBehaviour
{

    public Plantage[] plantages;
    public Flower[] flowers;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
        
    }

    void OnMouseDown()
    {
        plantages[i].FlowerPlanted(flowers[0]);

        plantages[i].FlowerIsWatered();

        plantages[i].FlowerReadyToPick();
    }
    
       
}
