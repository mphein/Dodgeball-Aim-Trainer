using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
    // learned from https://www.youtube.com/watch?v=xNHSGMKtlv4&ab_channel=JohnLeonardFrench
    public AudioMixer mixer;

    public void setLevel(float sliderVal)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderVal) * 20);
    }
}
