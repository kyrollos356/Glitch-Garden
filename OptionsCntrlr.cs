using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsCntrlr : MonoBehaviour {
    public Slider volumeslider;
    public Slider difficulty;
    private MusicMnanager musicmanager;
	
	void Start () {
        musicmanager = GameObject.FindObjectOfType<MusicMnanager>();//finding the object of type we created(MusicManager) and it is the only one 
        Debug.Log("found it : "+ musicmanager);
        volumeslider.value = playerprefsmngr.GetMasterVolume();
        difficulty.value = playerprefsmngr.GetDifficulty();
	}
	void Update () {
        musicmanager.changevolume(volumeslider.value);  
	}
    public void SaveAndExit() //saving values
    {
        playerprefsmngr.SetMasterVolume(volumeslider.value);
        playerprefsmngr.SetDifficultyValue(difficulty.value);
        Application.LoadLevel("Main");  
    }
    public void setdefault()
    {
        volumeslider.value = 1;
        difficulty.value = 2;
    }
   
}
