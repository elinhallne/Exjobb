using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAsset : MonoBehaviour
{
    public static FlowerAsset Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite[] daisySprites;
    public Sprite[] roseSprites;
    public Sprite[] tulipSprites;
    public Sprite[] violetSprites;

}
