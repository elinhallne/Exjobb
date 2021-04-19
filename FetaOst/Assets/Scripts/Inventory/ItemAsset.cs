using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAsset : MonoBehaviour
{
  public static ItemAsset Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;

    public Sprite waterCanSprite;
    public Sprite seedSprite;
    public Sprite daisySprite;
    public Sprite roseSprite;
    public Sprite tulipSprite;
    public Sprite violetSprite;
    public Sprite journalSprite;
}
