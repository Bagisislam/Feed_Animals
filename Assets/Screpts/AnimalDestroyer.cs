using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDestroyer : MonoBehaviour
{
    public float destroyBoundry;
    public ScorWiter _ScorWiter;
    public AudioSource _BackGroundAudio;
    public string[] ObjeTag;

    // Start is called before the first frame update
    void Start()
    {
        _ScorWiter = GameObject.Find("ScoreMeneger").GetComponent<ScorWiter>();
        _BackGroundAudio = GameObject.Find("BackGroundAudio").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z <= destroyBoundry)
        {
            //_ScorWiter.Countdown -= 15;
            Destroy(gameObject);
            TagobjeMethod("Horse",3);
            TagobjeMethod("Moose", 3);
            TagobjeMethod("Stag", 3);
            TagobjeMethod("Fox", 3);
            TagobjeMethod("Doe", 3);
            TagobjeMethod("Cow", 5);
            TagobjeMethod("Doberman", 3);
            TagobjeMethod("Shepherd", 3);
        }
        
    }

    private void TagobjeMethod( string _Animaltag,float _time)
    {
        if (gameObject. GetComponent<AnimalDestroyer>() != null)
        {
            foreach (var item in gameObject.GetComponent<AnimalDestroyer>().ObjeTag)
            {
                if (item == _Animaltag)
                {
                    
                    _ScorWiter.Countdown -= _time;
                }
            }
        }
    }
}
