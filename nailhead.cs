using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nailhead : MonoBehaviour {
    private Attackers attackobject;
    private GameObject obj;
    private Animator animate;
  
    void Start () {
        animate = GetComponent<Animator>();
        attackobject = GetComponent<Attackers>();
    }
	void OnTriggerEnter2D(Collider2D collider)
    {
        
        obj = collider.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            return;
        }
        else
        {
            animate.SetBool("Explode", true);
            attackobject.Attack(obj);
        }
    }
    void Death() {
        Destroy(gameObject);
    }
}
