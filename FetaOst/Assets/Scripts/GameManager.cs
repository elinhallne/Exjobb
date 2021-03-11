using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameManager : MonoBehaviour
{
    public static string currentTool = "none";
    
    public static Flowchart flowchart;
    
    public Character chr_Kawi;
    public Character chr_Unkel;

    [SerializeField]
    private PlantControler plantControler;

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
