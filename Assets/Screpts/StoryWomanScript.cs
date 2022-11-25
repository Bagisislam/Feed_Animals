using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class StoryWomanScript : MonoBehaviour
{
    public GameObject HeadOfHasband;
    public float speed;
    public float HeadRotation;
    public float WomanyYRotation;
    public TextMeshProUGUI WomanText;
    public TextMeshProUGUI ManText;
    public GameObject FirstCameraOfWoman;
    public GameObject FirstCameraOfMan;
    public GameObject SecendCameraOfMan;
    public GameObject SecendCemaraOfWoman;
    public GameObject ManCanvas;
    public GameObject WomanCanvas;
    public AudioSource _AudioSettings;
    public float _time;

    // Start is called before the first frame update
    void Start()
    {
        _AudioSettings = GameObject.Find("water-splash-sound-effect").GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
        _time = Time.time;
        HeadRotation = HeadOfHasband.transform.rotation.x;
        WomanyYRotation = transform.rotation.y;
        if (transform.position.x >= 79)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -56, 0), 1 * Time.deltaTime);
        }
        if (gameObject.transform.rotation.y >= -0.5f)
        {
            if (HeadOfHasband.transform.rotation.x >= -0.83423f)
            {
                HeadOfHasband.transform.Rotate(-1, 0, 0);
            }
        }

        if (transform.position.x <= 94.79f)
        {
            WomanText.fontSize = 6;
            WomanText.text = "Marta; " +
                "AHH Look at him i sought him all night.And now what I see.he has been drunk and seeps into the straw.What a husband isn't it ." +
                " Heyyyy  Georgie you moron get up  you have work to do . ";
            if (transform.position.x <= 86.275f)
            {

                WomanText.text = "";
                ManCameMehode();

                ManText.text = "George; " +
                        "Snore, snore, snore, snore ";
                if (transform.position.x <= 84.275f)
                {
                    ManText.text = "";

                    WomanCameMethod();
                    WomanText.text = "Marta;" +
                        "Hey George you alcoholic get up !!! ";
                }

                if (transform.position.x <= 82.3495f)
                {
                    WomanText.text = "Marta;" +
                        "You wanted to that!!! ";
                }
                if (transform.position.x <= 80.27)
                {
                    WomanText.text = "";
                    SecandManCameMehode();
                    ManText.text = "George;" +
                        "Wh..what da happening what are you doing you made me wet ahhh my headaches...What do you want from me old hag. ";
                    
                   
                }
            }
        }
        if (_time >= 26)
        {
            ManText.text = "";
            SecandWomanCameMethod();
            WomanText.text = "Marta; " +
                "Old hag, old hag ha I did all day farm works I fed the animals I cleaned the home cook the food and you treat me like that," +
                " Okey you are going to feed wild animals, maybe you will come to mind, go to take the food bucket. ";
        }

        if (_time >= 30)
        {
            WomanText.text = "";
            SecandManCameMehode();
            ManText.text = "George;Marta, you must be joking me ," +
                " the sun nearly set, what gonna do if a wild animal hurt me ?";
        }
        if (_time >= 33.5)
        {
            ManText.text = "";
            SecandWomanCameMethod();
            WomanText.text = "Marta; " +
                "Are you Going to or should I something to do about it? ";
        }
        if (_time >= 36)
        {
            WomanText.text = "";
            SecandManCameMehode();
            ManText.text = " George;Okey okey i am going to feed the animals.I can't fight with you, you were my head bloated in our last fight. ";
        }

        if (_time >= 39)
        {
            ManText.text = "";
            SecandWomanCameMethod();
            WomanText.text = "Marta; " +
                "here is my good husband, after that punishment I gonna make your favourite meals. ";
        }

        if (_time >= 42)
        {
            WomanText.text = "";
            SecandManCameMehode();
            ManText.text = "George; " + "i would eat them if i don't die...";
        }

        if (_time >= 44)
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "WaterSplash")
        {

            _AudioSettings.Play();
        }
    }

    private void SecandWomanCameMethod()
    {
        WomanText.fontSize = 6;
        ManCanvas.SetActive(false);
        WomanCanvas.SetActive(true);
        FirstCameraOfWoman.SetActive(false);
        FirstCameraOfMan.SetActive(false);
        SecendCameraOfMan.SetActive(false);
        SecendCemaraOfWoman.SetActive(true);
    }
    private void SecandManCameMehode()
    {
        ManText.fontSize = 6;
        ManCanvas.SetActive(true);
        WomanCanvas.SetActive(false);
        FirstCameraOfWoman.SetActive(false);
        FirstCameraOfMan.SetActive(false);
        SecendCemaraOfWoman.SetActive(false);
        SecendCameraOfMan.SetActive(true);
    }
    private void WomanCameMethod()
    {
        WomanText.fontSize = 6;
        ManCanvas.SetActive(false);
        WomanCanvas.SetActive(true);
        FirstCameraOfWoman.SetActive(true);
        FirstCameraOfMan.SetActive(false);
    }

    private void ManCameMehode()
    {
        ManText.fontSize = 6;
        ManCanvas.SetActive(true);
        WomanCanvas.SetActive(false);
        FirstCameraOfWoman.SetActive(false);
        FirstCameraOfMan.SetActive(true);
    }
}
