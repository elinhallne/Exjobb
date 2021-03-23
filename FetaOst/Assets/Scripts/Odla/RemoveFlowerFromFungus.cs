using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFlowerFromFungus : MonoBehaviour
{
 public void RemoveFlower()
    {
        Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
        Player.GetInventory().CheckForItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
        GameManager.haveFlower = false;
      
    }
}
