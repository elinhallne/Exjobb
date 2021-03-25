using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plantage : MonoBehaviour
{
	private Flower flower;
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
			Player.GetInventory().CheckForItem(new Item { itemType = Item.ItemType.Daisy, amount = 1 });
			timeToGrow = 0;
			emptyField = "empty";
			DestroyFlower();
			return true;
			
		    } 
		return false;
							
        }
	
	public void FlowerIsWatered()
    {
		if (GameManager.currentTool == "waterCan" && IsFiledEmety() == false && BrunnScript.amountOfWaterInCan > 0 )
		{
			spriteRendererFlower.sprite = flower.GrowStatus(timeToGrow, flower);

			BrunnScript.amountOfWaterInCan -= 0.1f;
			Debug.Log("Current Grow Time: " + timeToGrow);
			timeToGrow++;
		}
		
    }

	private int RandomInteger()
    {
		int randNr = UnityEngine.Random.Range(1, 4);
		return randNr;
    }
	
	public void FlowerPlanted()
    {
		//aFlower = new Flower();
		if (GameManager.currentTool == "seed" && IsFiledEmety() == true)
        {
			Player.GetInventory().RemoveItem(new Item { itemType = Item.ItemType.Seed, amount = 1 });
			flower = new Flower(RandomInteger());
			spriteRendererFlower.sprite = flower.GetSprite(flower.flowerType)[0];
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
		// behöver flyttas till innan den checkar fungus
		spriteRendererFlower.sprite = null;
		Destroy(flower);


	}

}
