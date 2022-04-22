using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour {

    [SerializeField] private Slider volumeSlider = null;

    public AudioMixer audioMixer;

    private void Start() {
        LoadValues();
    }

    void LoadValues() {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
    }

    public void SetVolume (float volume) {
        audioMixer.SetFloat("volume", volume);
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
    }
}
