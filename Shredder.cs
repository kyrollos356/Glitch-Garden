using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {
    GameObject obj; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        obj = collision.gameObject;
        Destroy(obj);   
    }
}
