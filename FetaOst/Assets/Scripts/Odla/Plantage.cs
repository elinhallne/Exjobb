﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plantage : MonoBehaviour
{
	public Flower flower;
	private float timeToGrow; //Variabeln som mäter hur långt den har växt
	public SpriteRenderer spriteRendererFlower;


	private string emptyField = "empty";
	
	public Plantage()
    {
		
    }

	/*public void PickingFlower() { 
	}*/

	public bool FlowerReadyToPick()
		{
		  if (flower.growTime == timeToGrow)
		    {
			Player.GetInventory().AddItem (new Item { itemType = Item.ItemType.Daisy, amount = 1 });
			timeToGrow = 0;
			emptyField = "empty";
			DestroyFlower();
			return true;
			
		    } 
		return false;
							
        }
	
	public void FlowerIsWatered()
    {
		if (GameManager.currentTool == "waterCan" && IsFiledEmety() == false)
		{
			spriteRendererFlower.sprite = flower.GrowStatus(timeToGrow, flower);
			
			Debug.Log(timeToGrow);
			timeToGrow++;
		}
		
    }
	
	public void FlowerPlanted(Flower aFlower)
    {
		flower = aFlower;
		if (GameManager.currentTool == "seed" && IsFiledEmety() == true)
        {
			spriteRendererFlower.sprite = aFlower.spriteRenderer.sprite;
			emptyField = "full";

		}
		

	}
	// denna bit bhöver ses över kan inte överför till false eller true
	// kontrollera om fältet är tomt
	private bool IsFiledEmety()
    {
		if (emptyField == "empty")
		{
			return true;
		}
		else 
		{
			return false;
		}
    }


	// kontrollera om fältet är tomt

	// Blomman plockas
	private void DestroyFlower()
    {
		spriteRendererFlower.sprite = null;
		flower = null;
		Destroy(flower);


	}

}
