using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharachterAsset : MonoBehaviour
{
    public static CharachterAsset Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Text[] kawiText;
    public Text[] unkelText;
    public Text[] noirText;

}
