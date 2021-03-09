using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Flower : MonoBehaviour
{
	public string name;
	public float growTime;
	public Sprite sprite;

	public Flower(string aName, float aGrowTime, Sprite aSprite)
	{
		name = aName;
		growTime = aGrowTime;
		sprite = aSprite;
	}

	//Update sprite med growtime?
}
