using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefsmngr : MonoBehaviour {
    const string MASTER_KEY_VOLUME = "master_volume";
    const string DIFFICUKTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked";

    public static void SetMasterVolume(float volume) {
        if (volume > 0 && volume < 1)
        {
            PlayerPrefs.SetFloat(MASTER_KEY_VOLUME, volume);
        }
        else { Debug.Log("hee heee hooo ya wala"); }
        }
    public static float GetMasterVolume() {
        return PlayerPrefs.GetFloat(MASTER_KEY_VOLUME);
    }
    public static void UnlockLevel(int level) {
        if (level <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString() , 1);
        }
        else { Debug.Log("out of level"); }
    }
    public static bool GetLevel(int level) {
        if (level <= Application.levelCount - 1) return false;
        else { return true; }
    }
    public static void SetDifficultyValue(float difficulty)
    {   if (difficulty>=1 &&difficulty<=3)
        PlayerPrefs.SetFloat(DIFFICUKTY_KEY , difficulty);
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICUKTY_KEY); 
    }
}
