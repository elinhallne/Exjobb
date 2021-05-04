using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllMeny : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void CheckIfAudioPlays()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();

        }
        else
        {
            audioSource.Stop();
        }
    }
}
