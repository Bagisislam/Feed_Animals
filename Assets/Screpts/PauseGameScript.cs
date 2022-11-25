using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour
{
    public GameObject InGameCaravan;
    public GameObject EndGameCaravan;
    public GameObject PauseGamaCaravan;
    public void PauseBut()
    {

        EndGameCaravan.SetActive(false);
        PauseGamaCaravan.SetActive(false);
        InGameCaravan.SetActive(true);
        Time.timeScale = 1;
        
    }

}
