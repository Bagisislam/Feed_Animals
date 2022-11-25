using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenegerAnimationScript : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource _AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
        InvokeRepeating("RandomSoundMenegerMehtod",0,7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomSoundMenegerMehtod()
    {
        AudioClip clip = audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
        _AudioSource.PlayOneShot(clip);
        
    }
}
