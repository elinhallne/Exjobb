using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrunnScript : MonoBehaviour
{
    public static int amountOfWaterInCan;
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
        if (GameManager.currentTool == "waterCan")
        {
            amountOfWaterInCan = 1;
        }
    }
}
