using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public AudioClip lvl1Music;

    private AudioSource source; 

    void Awake ()
    {
        source = GetComponent<AudioSource>();

        source.clip = lvl1Music;
        source.Play();
    }
    
    public void StopBGM()
    {
        source.Stop()
    }
}
