using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item 
{
    public enum ItemType
    {
        WaterCan,
        Seed,
        Daisy,
        Rose,
        Tulip,
        Violet,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.WaterCan: return ItemAsset.Instance.waterCanSprite;
            case ItemType.Seed:     return ItemAsset.Instance.seedSprite;
            case ItemType.Daisy:    return ItemAsset.Instance.daisySprite;
            case ItemType.Rose:     return ItemAsset.Instance.roseSprite;
            case ItemType.Tulip:    return ItemAsset.Instance.tulipSprite;
            case ItemType.Violet:   return ItemAsset.Instance.violetSprite;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.Seed:
            case ItemType.WaterCan:
            case ItemType.Daisy:
                return true;
           
            case ItemType.Rose:
            case ItemType.Tulip:
            case ItemType.Violet:
                    return false;
        }
    }
     public bool IsFlower()
    {
        switch (itemType)
        {
            default:
            case ItemType.Daisy:
            case ItemType.Rose:
            case ItemType.Tulip:
            case ItemType.Violet:
                return true;
            case ItemType.Seed:
            case ItemType.WaterCan:
                return false;
        }
          
    }

}
