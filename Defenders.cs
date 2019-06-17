using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {
    private bool istrigger =true ;
    Attackers AttackerHit;
    private void Start()
    {

    }
   
    private bool OnTriggerEnter2D()
    {
        Debug.Log(name + "object entered");return istrigger; 
    }
}
