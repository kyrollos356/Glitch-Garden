using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicMnanager : MonoBehaviour {
    public AudioClip[] levelmusic;
    private AudioSource musicSource;
     void Awake()
    {
        DontDestroyOnLoad(gameObject);   
    }
     void Start()
    {
       musicSource =  GetComponent<AudioSource>();  
    }
     void OnLevelWasLoaded(int level)
    {
        
        AudioClip thislevelmusic = levelmusic[level];
        Debug.Log("music name :" + thislevelmusic + Application.loadedLevel);
        if (thislevelmusic)
        {
            musicSource.clip = thislevelmusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }public void changevolume(float volume) {
        musicSource.volume = volume;
    }
}
