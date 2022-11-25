using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DetectCollider : MonoBehaviour
{
    public AudioSource _AudioSource;
    ScorMeneger _ScorMeneger;
    // Start is called before the first frame update
    void Start()
    {
        _AudioSource = GameObject.Find("HitAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        _AudioSource.Play();
    }

}
