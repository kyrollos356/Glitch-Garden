using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OnStart : MonoBehaviour {
   
   public float BeforeLoad ;
    // Use this for initialization
    void Start()
    {if (BeforeLoad!=0)
        Invoke("LoadLevel", BeforeLoad);
    }
    void LoadLevel()
    {
        Application.LoadLevel("Main");
    }  
}
