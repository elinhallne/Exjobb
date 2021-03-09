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
    public static bool dailyFlowerGiven;

    public Character chr_Kawi;
    public Character chr_Unkel;

    // Start is called before the first frame update
    void Start()
    {
        //kommer säkert behöva skriva en funktion för hur det funkar
        flowchart = GetComponent<Flowchart>();
      
        chr_Kawi.loveMeter.SetSize(0f);
        chr_Unkel.loveMeter.SetSize(0f);
     

    }
    

    // Update is called once per frame
    void Update()
    {
        dailyFlowerGiven = flowchart.GetBooleanVariable("DailyFlowerGiven");
        haveFlower = flowchart.GetBooleanVariable("HaveFlower");
        FlowerImageSetActive(haveFlower, gobj_FlowerImage);
        chr_Kawi.loveMeterValue = flowchart.GetFloatVariable("KwaiLoveMeter");
        chr_Unkel.loveMeterValue = flowchart.GetFloatVariable("UnkelLoveMeter");
        

        chr_Kawi.UpdateLoveValue();
        chr_Unkel.UpdateLoveValue();

        

    }

    private void FlowerImageSetActive(bool _bool, GameObject _gameObject)
    {
        
            _gameObject.SetActive(_bool);
                       
    }


}
