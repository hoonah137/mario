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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
