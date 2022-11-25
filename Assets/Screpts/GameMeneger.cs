using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMeneger : MonoBehaviour
{
    public GameObject InGameCaravan;
    public GameObject EndGameCaravan;
    public GameObject PauseCaravan;
    bool forEsc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (/*Input.GetKeyDown(KeyCode.Escape) &&*/ forEsc == true)
            {


                EndGameCaravan.SetActive(false);
                PauseCaravan.SetActive(false);
                InGameCaravan.SetActive(true);
                Time.timeScale = 1;

                forEsc = false;


            }
            else
            {
                PauseCaravan.SetActive(true);
                Time.timeScale = 0;
                forEsc = true;

            }
            
        }
        

    }
}
