using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBtn : MonoBehaviour
{
    public GameObject InGameCaravan;
    public GameObject EndGameCaravan;
    public GameObject PauseCravan;
    public GameObject VolumeSetCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingBtn_For_Ýnterface()
    {
        InGameCaravan.SetActive(false);
        EndGameCaravan.SetActive(false);
        PauseCravan.SetActive(false);
        VolumeSetCanvas.SetActive(true);
    }
}
