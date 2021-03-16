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
	public SpriteRenderer spriteRenderer; //ta bort
	
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
		
		spriteRenderer.sprite = sprites[0];
    }

	public Sprite GrowStatus(float currentGrowTime, Flower aFlower)
    {
		switch (currentGrowTime)
		{
			default: return aFlower.GetSprite(aFlower.flowerType)[currentSpriteNum];
			case 0f: return aFlower.GetSprite(aFlower.flowerType)[0];
			case 2f: return UpdateSpriteRenderer(currentGrowTime, aFlower);
			case 4f: return UpdateSpriteRenderer(currentGrowTime, aFlower);
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
				
				break;
			case FlowerType.Rose:
				growTime = 8;
				break;
			case FlowerType.Tulip:
				growTime = 4;
				break;
			case FlowerType.Violet:
				growTime = 5;
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
