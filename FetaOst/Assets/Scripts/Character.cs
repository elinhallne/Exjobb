using System;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


[System.Serializable]
public class Character
{
	public string name;
	public LoveMeter loveMeter;
	public float loveMeterValue;
		
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
