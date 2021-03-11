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
	private int currentSpriteNum;


	public Flower(string aName, float aGrowTime, SpriteRenderer aSpriteRenderer)
	{
		name = aName;
		growTime = aGrowTime;
		spriteRenderer = aSpriteRenderer;
			
	}

	void GrowStatus(float currentGrowTime)
    {
		if (currentGrowTime == 2)
        {

        }
    }

	//Update sprite med growtime?
}
