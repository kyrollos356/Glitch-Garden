using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizzard : MonoBehaviour{
    private Attackers attackobject;
    private GameObject obj;
    Projectile projectile;
    Health defenderHealth;
    float defenderHealthValue;
    private Animator animate;
    bool thereIsADefender= false;
    void Start()
    {
        animate = GetComponent<Animator>();
        attackobject = GetComponent<Attackers>();
       
    }

    private void Update()
    {
        if (thereIsADefender)
        {
            defenderHealthValue = defenderHealth.health;
            if (defenderHealthValue <= 0) { animate.SetBool("isAttacking", false); }
        }
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
            animate.SetBool("isAttacking", true);
            attackobject.Attack(obj);
            thereIsADefender = true;
            defenderHealth = obj.GetComponent<Health>();
            thereIsADefender = true;

            defenderHealthValue = defenderHealth.health;
        }
    }
  
}