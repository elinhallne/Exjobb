using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameManager : MonoBehaviour
{
    public static string currentTool = "none";
    public static bool flowerPickable;
    public bool haveFlower;
    public GameObject gobj_FlowerImage;
    
    
    public static Flowchart flowchart;


    // Start is called before the first frame update
    void Start()
    {
        //kommer säkert behöva skriva en funktion för hur det funkar
        flowchart = GetComponent<Flowchart>();

    }
    

    // Update is called once per frame
    void Update()
    {
        haveFlower = flowchart.GetBooleanVariable("HaveFlower");
        FlowerImageSetActive(haveFlower, gobj_FlowerImage);
       
    }

    private void FlowerImageSetActive(bool _bool, GameObject _gameObject)
    {
        
        if (_bool == true)
        {
            _gameObject.SetActive(true);
                       
        }
        if (haveFlower == false)
            _gameObject.SetActive(false);
    }
    

}
