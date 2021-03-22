using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Flower : MonoBehaviour
{
	public enum FlowerType
	{
		Daisy,
		Rose,
		Tulip,
		Violet,
	}

	public FlowerType flowerType;

	public float growTime;
	private SpriteRenderer spriteRenderer;
	private float x, y, z;

	[SerializeField]
	private Sprite[] sprites;
	private int currentSpriteNum = 0;

	public Flower(int randomNumber)
    {
		flowerType = RandomTypeOfFlower(randomNumber);
		sprites = GetSprite(flowerType);
		GetFlowerInformation(flowerType);
    }

	

	private void Awake()
    {
		
		//spriteRenderer.sprite = sprites[0];
    }


	//det behövs att man kan anpassa längden till 
	public Sprite GrowStatus(float currentGrowTime, Flower aFlower)
    {
		if(currentGrowTime == x) {
			return aFlower.GetSprite(aFlower.flowerType)[0];
		}
		else if (currentGrowTime == y) {
			return UpdateSpriteRenderer(currentGrowTime, aFlower);
		}
		else if ( currentGrowTime == z){
			return UpdateSpriteRenderer(currentGrowTime, aFlower);
		}
        else
        {
			return aFlower.GetSprite(aFlower.flowerType)[currentSpriteNum];
		}
		
    }

	private Sprite UpdateSpriteRenderer(float currentGrowTime, Flower aFlower)
    {
		if (currentGrowTime < growTime)
		{
			currentSpriteNum++;
		}
        else
        {
			currentSpriteNum = 0;
        }
		Sprite sprite = aFlower.GetSprite(aFlower.flowerType)[currentSpriteNum];
		
			
	    return sprite;

	}

	private FlowerType RandomTypeOfFlower(int randNr)
    {
		
        switch (randNr)
        {
			default:
			case 1: return FlowerType.Daisy;
			case 2: return FlowerType.Rose;
			case 3: return FlowerType.Tulip;
			case 4: return FlowerType.Violet;
			
        }
    }

	//Update sprite med growtime?
	public void GetFlowerInformation(FlowerType flowerType)
    {
		switch (flowerType)
        {
			case FlowerType.Daisy:
				
				growTime = 6;
				x = 2;
				y = 3;
				z = 4;
				break;
			case FlowerType.Rose:
				growTime = 8;
				x = 2;
				y = 4;
				z = 6;
				break;
			case FlowerType.Tulip:
				growTime = 4;
				x = 0;
				y = 1;
				z = 2;
				break;
			case FlowerType.Violet:
				growTime = 5;
				x = 1;
				y = 2;
				z = 3;
				break;


        }
    }

	public Sprite[] GetSprite(FlowerType flowerType)
    {
        switch (flowerType) {
			default:
			case FlowerType.Daisy:  return FlowerAsset.Instance.daisySprites;							
			case FlowerType.Rose:   return FlowerAsset.Instance.roseSprites;
			case FlowerType.Tulip:  return FlowerAsset.Instance.tulipSprites;
			case FlowerType.Violet: return FlowerAsset.Instance.violetSprites;
		}
    }
}
