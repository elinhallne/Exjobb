using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChange;

    private List<Item> itemList;
    private Action<Item> useItemAction;

    public Inventory(Action<Item> useItemAction)
    {
        this.useItemAction = useItemAction;
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Seed, amount = 5 });
        AddItem(new Item { itemType = Item.ItemType.WaterCan, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Rose, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Tulip, amount = 1 });

        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        if (item.IsStackable())
        {
            bool itemAlreadyInInventory = false;
            foreach(Item inverntoryItem in itemList)
            {
                if(inverntoryItem.itemType == item.itemType)
                {
                    Debug.Log(item.amount + " 1");
                    inverntoryItem.amount += item.amount;
                    Debug.Log(item.amount + " 2");
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

    public void ChooseItem (Item item)
    {
        useItemAction(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
        
}
