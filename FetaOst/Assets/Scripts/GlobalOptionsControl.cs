using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GlobalOptionsControl : MonoBehaviour
{
    public static GlobalOptionsControl Instance;

    //Från ChangeText
    public int counter;
   // public int textColourCount;
   // public Color currentColour;

    //från MenySettings
    public float volume;


    
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
