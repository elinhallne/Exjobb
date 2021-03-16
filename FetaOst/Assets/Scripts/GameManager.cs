using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameManager : MonoBehaviour
{
    public static string currentTool = "none";
    public static bool haveFlower = false;
     public static Flowchart flowchart;
    
    public Character chr_Kawi;
    public Character chr_Unkel;

    [SerializeField]
    private PlantControler plantControler;

    private bool removeItem;

    // Start is called before the first frame update
    void Start()
    {
        //kommer säkert behöva skriva en funktion för hur det funkar
        flowchart = GetComponent<Flowchart>();
        flowchart.SetBooleanVariable("HaveFlower", haveFlower);
        removeItem = flowchart.GetBooleanVariable("RemoveItem");



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

        UpdateFungusVariabels();

    }

    private void UpdateFungusVariabels()
    {
        flowchart.SetBooleanVariable("HaveFlower", haveFlower);
        removeItem = flowchart.GetBooleanVariable("RemoveItem");
        if (removeItem == true)
        {
            Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
            Debug.Log("I Have removed ");
            Player.GetInventory().CheckForItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
            flowchart.SetBooleanVariable("RemoveItem", false);
        }
    }
}
