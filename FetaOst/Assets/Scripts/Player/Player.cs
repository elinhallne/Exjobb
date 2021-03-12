using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] 
    private UI_Inventory uiInventory;

    private Inventory inventory;

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
        switch (item.itemType)
        {
            case Item.ItemType.Seed:
                GameManager.currentTool = "seed";
                break;
            case Item.ItemType.WaterCan:
                GameManager.currentTool = "waterCan";
                break;
        }
    }
}
