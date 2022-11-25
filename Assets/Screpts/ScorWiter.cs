using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorWiter : MonoBehaviour
{
    public TextMeshProUGUI _TextMeshProUGUI;
    public TextMeshProUGUI HightScoreText;
    public TextMeshProUGUI GameTimeText;
    public AudioSource _BackGroundAudio;
    public GameObject InCanvas;
    public GameObject EndCanvas;
    public GameObject PauseCanvas;
    public GameObject PlayerObje;
    public int Score;
    public int HightScor;
    public float Countdown;
    public int GameOverTimer;
    // Start is called before the first frame update
    void Start()
    {
        HightScor = PlayerPrefs.GetInt("hs");
        _BackGroundAudio = GameObject.Find("BackGroundAudio").GetComponent<AudioSource>();
        _TextMeshProUGUI.color = Color.green;
        GameTimeText.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= 1 * Time.deltaTime;
        GameTimeText.text = "Time; " + Countdown.ToString("0");
        _TextMeshProUGUI.text = "Score: " + Score.ToString();
        if (Countdown < GameOverTimer)
        {
            
            Destroy(PlayerObje);
            Die();
            _BackGroundAudio.Stop();

        }
    }

    public void GameOverMethdo()
    {
        
    }

    public void Die()
    {
        if (Score > HightScor)
        {
            HightScor = Score;
            PlayerPrefs.SetInt("hs", HightScor);
        }
        EndCanvas.SetActive(true);
        InCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
        HightScoreText.text = "Hight Score: " + HightScor.ToString();
        //Time.timeScale = 0;

    }

}
