using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] 
    private UI_Inventory uiInventory;
    [SerializeField]
    private GameObject goj_Journal;

    private static Inventory inventory;

   private void Awake()
    {
        inventory = new Inventory(ChooseItem);
        uiInventory.SetInventory(inventory);

       
    }

    private void OnTriggerEnter(Collider collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
    //här väljer jag vad de gör
    private void ChooseItem(Item item)

    {
        Debug.Log("Item: " + item.itemType);
        
        switch (item.itemType)
        {
            case Item.ItemType.Seed:
                {
                    GameManager.currentTool = "seed";                    
                    break;
                }

            case Item.ItemType.WaterCan:
                GameManager.currentTool = "waterCan";
                break;

            case Item.ItemType.Daisy:
                GameManager.currentTool = "daisy";                
                break;

            case Item.ItemType.Rose:
                GameManager.currentTool = "rose";
                break;

            case Item.ItemType.Tulip:
                GameManager.currentTool = "tulip";
                break;

            case Item.ItemType.Violet:
                GameManager.currentTool = "violet";
                break;

            case Item.ItemType.Journal:
                goj_Journal.SetActive(true);
                break;
        }
    }

    public static Inventory GetInventory()
    {
        return inventory;
    }
}
