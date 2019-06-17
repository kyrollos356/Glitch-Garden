using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public  float speed = 5f, damage = 5f;
    float attackerHealthValue ;
    Health attackerHealth;
    GameObject attacker; 
    private void Update()
    {
        transform.Translate (Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D attackerEngaging)
    {
        attacker = attackerEngaging.gameObject;
        if (attacker.GetComponent<Attackers>()) {
            Debug.Log(attacker.name);
            attackerHealth = attacker.GetComponent<Health>();
            attackerHealth.DamageDone(damage);
            Destroy(gameObject);
        }
    }
}
