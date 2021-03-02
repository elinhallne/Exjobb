using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCan : MonoBehaviour
{
    
    void Start()
    {
        Button wBtn = GetComponent<Button>();
        wBtn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        GameManager.currentTool = "waterCan";
        Debug.Log(GameManager.currentTool);
    }
}
