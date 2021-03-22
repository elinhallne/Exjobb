using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterKlicked : MonoBehaviour
{
    
    void OnMouseDown() //collider sitter på denna
    {
        Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Seed, amount = 1 });
    }

}
