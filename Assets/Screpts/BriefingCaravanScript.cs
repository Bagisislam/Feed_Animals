using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefingCaravanScript : MonoBehaviour
{
    public GameObject _brieingCanvas;
    public GameObject _GameMeneger;

    // Start is called before the first frame update
    void Start()
    {
        _GameMeneger.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _GameMeneger.SetActive(true);
            _brieingCanvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
