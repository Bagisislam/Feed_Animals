using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class MenuSettingVolumeScript : MonoBehaviour
{
    public TextMeshProUGUI _VolumeValeuText;
    public Slider _VolumeSlider;
    public GameObject _StartMenuCanvas;
    public GameObject _StartVolumeMenuCanvas;
    public AudioSource _AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SliderBtn_For_Start_Menu(float volume)
    {
        _VolumeValeuText.text = volume.ToString("0.0");
    }

    public void SaveBtn_For_Start_Menu()
    {
        float volumeValue = _VolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue",volumeValue);
        _StartVolumeMenuCanvas.SetActive(false);
        _StartMenuCanvas.SetActive(true);
        LoudeValue_For_Start_Menu();
    }

    private void LoudeValue_For_Start_Menu()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        _VolumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
        _AudioSource.volume = volumeValue;
    }
}
