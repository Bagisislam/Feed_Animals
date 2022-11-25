using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    public GameObject VolumeSettingsCanvas;
    public GameObject StartMenuCanvas;
    public void StartBtn()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void SettingBtnMenu()
    {
        VolumeSettingsCanvas.SetActive(true);
        StartMenuCanvas.SetActive(false);
    }
}
