using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Flower : MonoBehaviour
{
	public string name;
	public float growTime;
	public SpriteRenderer spriteRenderer;
	
	[SerializeField]
	private Sprite[] sprites;
	private int currentSpriteNum = 0;


	public Flower(string aName, float aGrowTime, SpriteRenderer aSpriteRenderer)
	{
		name = aName;
		growTime = aGrowTime;
		spriteRenderer = aSpriteRenderer;
			
	}
	private void Awake()
    {
		spriteRenderer.sprite = sprites[0];
    }

	public Sprite GrowStatus(float currentGrowTime, Flower aFlower)
    {
		switch (currentGrowTime) 
		{
			default:
				return aFlower.spriteRenderer.sprite;
			case 0f:
				return aFlower.spriteRenderer.sprite = sprites[0];
			case 2f:
				UpdateSpriteRenderer(aFlower);
				return aFlower.spriteRenderer.sprite;
			case 4f:
				UpdateSpriteRenderer(aFlower);
				return aFlower.spriteRenderer.sprite;
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
		aFlower.spriteRenderer.sprite= sprites[currentSpriteNum];
		
			
	    return aFlower.spriteRenderer.sprite;

	}
	//Update sprite med growtime?
}
