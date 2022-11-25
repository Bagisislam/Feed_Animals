using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FireMeneger : MonoBehaviour
{
    public TextMeshProUGUI ImageText;
    public GameObject[] _gameObject;
    public Sprite[] _sprites;
    public Image Image;
    public GameObject CorrectObje;
    private int Correctnumber = 5;
    // Start is called before the first frame update
    void Start()
    {
        CorrectObje = _gameObject[0];
        Image.sprite = _sprites[0];
        ImageText.text = "Carrot";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && Correctnumber == 3)
        {
            CorrectObje = _gameObject[2];
            Image.sprite = _sprites[2];
            ImageText.text = "Steak";
            Correctnumber = 2;
        }
        if (Input.GetKeyDown(KeyCode.W) && Correctnumber == 4)
        {
            CorrectObje = _gameObject[1];
            Image.sprite = _sprites[1];
            ImageText.text = "Appel";
            Correctnumber = 3;
        }

        if (Input.GetKeyDown(KeyCode.W) && Correctnumber == 5)
        {
            CorrectObje = _gameObject[0];
            Image.sprite = _sprites[0];
            Correctnumber = 4;
        }
        if (Input.GetKeyDown(KeyCode.W) && Correctnumber == 2)
        {
            Correctnumber = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(CorrectObje, transform.position, transform.rotation);
        }

    }



}
