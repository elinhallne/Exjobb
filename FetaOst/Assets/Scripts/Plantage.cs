using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plantage : MonoBehaviour
{
	public Flower flower;
	private float timeToGrow; //Variabeln som mäter hur långt den har växt
	
	public Plantage()
    {

    }

	public Plantage( Flower aFlower)
	{
		flower = aFlower;	
	}

	private bool FlowerReadyToPick()
		{
		  if (flower.growTime == timeToGrow)
		    {
				return true;
		    } 
		return false;
							
        }
	
	public void FlowerIsWatered()
    {
		timeToGrow++;
    }
	

	// Planterad blommad if man har ett för så kan den planteras annars har man iget 

	// kontrollera om fältet är tomt

	// Blomman plockas
	private void DestroyFlower()
    {
		Destroy(flower);
    }

}
