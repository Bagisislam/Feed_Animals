using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScorMeneger : MonoBehaviour
{
    public ScorWiter _ScorWiter;
    public AnimalDestroyer _animalDestroyer;
    // Start is called before the first frame update
    void Start()
    {
        _animalDestroyer = GetComponent<AnimalDestroyer>();
        _ScorWiter = GameObject.Find("ScoreMeneger").GetComponent<ScorWiter>();
    }

    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AnimalsTag")
        {
            _ScorWiter.Score += 1;
            _ScorWiter.Countdown += 1;
        }
        TagobjeMethod(other, "Shepherd","SteakFood",10,3f);
        TagobjeMethod(other, "Doberman", "SteakFood", 10, 3f);
        TagobjeMethod(other, "Fox", "SteakFood", 10, 2.5f);
        TagobjeMethod(other, "Cow", "Cattor", 5, 2);
        TagobjeMethod(other, "Doe", "Cattor", 8, 2.5f);
        TagobjeMethod(other, "Stag", "Cattor", 8, 2.5f);
        TagobjeMethod(other, "Horse", "Apple", 15, 4);
        TagobjeMethod(other, "Moose", "Apple", 8, 2.5f);

    }

    private void TagobjeMethod(Collider other,string _Animaltag,string _foodobje,int _score,float _time)
    {
        if (other.GetComponent<AnimalDestroyer>() != null)
        {
            foreach (var item in other.GetComponent<AnimalDestroyer>().ObjeTag)
            {
                if (item == _Animaltag && gameObject.tag== _foodobje)
                {
                    _ScorWiter.Score += _score;
                    _ScorWiter.Countdown += _time;
                }
            }
        }
    }
}
