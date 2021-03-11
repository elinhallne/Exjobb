using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plantage : MonoBehaviour
{
	Plantage plantage;
	public Flower flower;
	private float timeToGrow; //Variabeln som mäter hur långt den har växt
	public SpriteRenderer spriteRendererFlower;

	private string emptyField = "empty";
	
	public Plantage()
    {
		plantage = new Plantage();
    }

	/*public void PickingFlower() { 
	}*/

	public bool FlowerReadyToPick()
		{
		  if (flower.growTime == timeToGrow)
		    {
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

	// Planterad blommad if man har ett för så kan den planteras annars har man iget 

	// kontrollera om fältet är tomt

	// Blomman plockas
	private void DestroyFlower()
    {
		spriteRendererFlower.sprite = null;
		flower = null;
		Destroy(flower);


	}

}
