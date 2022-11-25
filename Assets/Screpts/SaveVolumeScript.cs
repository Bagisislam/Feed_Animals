using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class SaveVolumeScript : MonoBehaviour
{
    public TextMeshProUGUI _VolumeText=null;
    public Slider _VolumeSlider = null;
    public GameObject VolumeSettingsCanvas;
    public GameObject InGameCaravan;
    public GameObject EndGameCaravan;
    public GameObject PauseCravan;
    // Start is called before the first frame update
    void Start()
    {
        LoudValue();
    }

    public void SliderBtn(float volume)
    {
        _VolumeText.text = volume.ToString("0.0");
    }

    public void SaveBtn()
    {
        float volumeValue = _VolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue",volumeValue);
        VolumeSettingsCanvas.SetActive(false);
        InGameCaravan.SetActive(false);
        EndGameCaravan.SetActive(false);
        PauseCravan.SetActive(true);
        LoudValue();
    }

    private void LoudValue()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        _VolumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
