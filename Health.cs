using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health = 100;
    private float HitValue=0f;
 
    public void DamageDone(float damage)
    {
        health -= damage;
        if (health <=0)
        {
            Destroy(gameObject);
        }
    }
}
