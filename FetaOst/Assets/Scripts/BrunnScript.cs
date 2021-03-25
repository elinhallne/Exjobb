using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrunnScript : MonoBehaviour
{
    public static float amountOfWaterInCan;
    public LoveMeter waterCanMeter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waterCanMeter.SetSize(amountOfWaterInCan);
    }

    void OnMouseDown()
    {
        if (GameManager.currentTool == "waterCan")
        {
            amountOfWaterInCan = 1;
        }
    }
}
