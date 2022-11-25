using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayeAgainScript : MonoBehaviour
{
    public GameObject InGameCaravan;
    public GameObject EndGameCaravan;
    public GameObject PauseCravan;

    public void PlayAgainBtn()
    {
        
        SceneManager.LoadScene(3);
        InGameCaravan.SetActive(true);
        EndGameCaravan.SetActive(false);
        PauseCravan.SetActive(false);

        Time.timeScale = 1;
    }
}
