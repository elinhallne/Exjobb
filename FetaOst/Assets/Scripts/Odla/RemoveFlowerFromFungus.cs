using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFlowerFromFungus : MonoBehaviour
{
    
 public void RemoveFlower()
    {
        Player.GetInventory().RemoveBasedOnTypeFlower();

    }
}
