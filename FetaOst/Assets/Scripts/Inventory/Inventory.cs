using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Inventory
{
    public event System.EventHandler OnItemListChange;

    private List<Item> itemList;
    private Action<Item> useItemAction;

    public Inventory(Action<Item> useItemAction)
    {
        this.useItemAction = useItemAction;
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Seed, amount = 5 });
        AddItem(new Item { itemType = Item.ItemType.WaterCan, amount = 1 });


        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        if (item.IsStackable())
        {
            bool itemAlreadyInInventory = false;
            foreach (Item inverntoryItem in itemList)
            {
                if (inverntoryItem.itemType == item.itemType)
                {

                    inverntoryItem.amount += item.amount;
                    itemAlreadyInInventory = true;
                }
            }
            if (!itemAlreadyInInventory)
            {
                itemList.Add(item);
            }
        }
        else
        {
            itemList.Add(item);
        }

        OnItemListChange?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(Item item)
    {
        if (item.IsStackable())
        {
            Item itemInInventory = null;
            foreach (Item inventoryItem in itemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount -= item.amount;
                    itemInInventory = inventoryItem;
                }
            }
            if (itemInInventory != null && itemInInventory.amount <= 0)
            {
                itemList.Remove(itemInInventory);
            }
            else
            {
                itemList.Remove(item);
            }
            OnItemListChange?.Invoke(this, EventArgs.Empty);
        }
    }

    public void ChooseItem(Item item)
    {
        useItemAction(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

   public void CheckForItem()
    {
        bool notInInventory = false;
        foreach (Item itemInIventory in itemList)
        {
            
            if (itemInIventory.itemType == Item.ItemType.Daisy || itemInIventory.itemType == Item.ItemType.Rose || itemInIventory.itemType == Item.ItemType.Tulip || itemInIventory.itemType == Item.ItemType.Violet)
            {
                Debug.Log("true");
                notInInventory = true;
                GameManager.flowchart.SetBooleanVariable("HaveFlower", true);
       
            }
        }
          if (!notInInventory)
            {
                Debug.Log("false");
                GameManager.flowchart.SetBooleanVariable("HaveFlower", false);

        }

    }

    public void RemoveBasedOnTypeFlower()
    {
        foreach(Item flowerItemInInventory in itemList)
        {
            if(flowerItemInInventory.itemType == Item.ItemType.Daisy)
            {
                Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
                Player.GetInventory().CheckForItem();
                Debug.Log("Tog bort Daisy");
            } 
            else if (flowerItemInInventory.itemType == Item.ItemType.Rose)
            {
                Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Rose, amount = 1 });
                Player.GetInventory().CheckForItem();
                Debug.Log("Tog bort Rose");
            }
            else if (flowerItemInInventory.itemType == Item.ItemType.Tulip)
            {
                Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Tulip, amount = 1 });
                Player.GetInventory().CheckForItem();
                Debug.Log("Tog bort Tulip");
            }
            else if (flowerItemInInventory.itemType == Item.ItemType.Violet)
            {
                Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Violet, amount = 1 });
                Player.GetInventory().CheckForItem();
                Debug.Log("Tog bort Violet");
            }
            else
            {
                Debug.Log("Du är dum");
            }
        }
    }
}
        

