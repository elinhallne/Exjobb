using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public Dropdown resolutionDropDown;

    public Dropdown GraphicsDropDown;

    Resolution[] resolutions;

    Font[] myFonts;



    void Start()
    {
        audioMixer = GlobalOptionsControl.Instance.audioMixer;
        resolutionDropDown.value = GlobalOptionsControl.Instance.resolutionDropDown;
        GraphicsDropDown.value = GlobalOptionsControl.Instance.GraphicsDropDown;

       resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();
        int CurrentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentResolutionIndex = i;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = CurrentResolutionIndex;
        resolutionDropDown.RefreshShownValue();

        

    }
    private void Update()
    {
        SaveData();
    }
    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    public void SetVolume (float volume)
    {
       
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    
    private void SaveData()
    {
        GlobalOptionsControl.Instance.audioMixer = audioMixer;
        GlobalOptionsControl.Instance.resolutionDropDown = resolutionDropDown.value;
        GlobalOptionsControl.Instance.GraphicsDropDown = GraphicsDropDown.value;      
}
}
