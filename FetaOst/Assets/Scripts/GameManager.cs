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

    public LoveMeter kawiLoveMeter;
    private float kawiLoveValue;

    public LoveMeter unkelLoveMeter;
    private float unkelLoveValue;

    // Start is called before the first frame update
    void Start()
    {
        //kommer säkert behöva skriva en funktion för hur det funkar
        flowchart = GetComponent<Flowchart>();
      
        kawiLoveMeter.SetSize(0f);
        unkelLoveMeter.SetSize(0f);

    }
    

    // Update is called once per frame
    void Update()
    {
        dailyFlowerGiven = flowchart.GetBooleanVariable("DailyFlowerGiven");
        haveFlower = flowchart.GetBooleanVariable("HaveFlower");
        FlowerImageSetActive(haveFlower, gobj_FlowerImage);
        kawiLoveValue = flowchart.GetFloatVariable("KwaiLoveMeter");
        unkelLoveValue = flowchart.GetFloatVariable("UnkelLoveMeter");


        UpdateLoveValue(kawiLoveMeter,kawiLoveValue);
        UpdateLoveValue(unkelLoveMeter, unkelLoveValue);
    }

    private void FlowerImageSetActive(bool _bool, GameObject _gameObject)
    {
        
            _gameObject.SetActive(_bool);
                       
    }

    void UpdateLoveValue(LoveMeter _loveMeter, float _float)
    {
        _loveMeter.SetSize(_float);
    }
    

}
