using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


[System.Serializable]
public class Character
{
	public string name;
	public GameObject gameObject;
	public LoveMeter loveMeter;
	public float loveMeterValue;
	public GameObject journal;
		
	public Character(string aName, LoveMeter aLoveMeter)
	{
		name = aName;
		loveMeter = aLoveMeter;
	}

	public void UpdateLoveValue()
	{
		loveMeter.SetSize(loveMeterValue);
	}
}
