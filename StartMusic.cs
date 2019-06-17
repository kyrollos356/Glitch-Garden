using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {
    private MusicMnanager soundlevel;
    private float sound; 
	void Start () {
        soundlevel = GameObject.FindObjectOfType<MusicMnanager>();
        sound = playerprefsmngr.GetMasterVolume();
        soundlevel.changevolume(sound);
    }
	
	void Update () {
    
	}
}
