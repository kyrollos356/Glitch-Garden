using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof (Attackers)) ]

public class Fox : MonoBehaviour {

    private Attackers attackobject;
    private GameObject obj;
    private Animator animate;

    /// <summary>
    /// 
    /// </summary>

    void Start () {
        animate = GetComponent<Animator>();
        attackobject = GetComponent<Attackers>();
	}

    /// <summary>
    /// 
    /// </summary>
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        obj = collider.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            return; 
        }
        if (obj.GetComponent<Stone>())
        {
            animate.SetBool("isJumping", true);
        
        }
        else
        {
            animate.SetBool("isAttacking", true);
            attackobject.Attack(obj);
        }Invoke("invokebool" , 0.5f);
        
        }
    /// <summary>
    /// 
    /// </summary>
     private void invokebool() { animate.SetBool("isJumping" ,false); }
}
