using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _AttackerSpawner : MonoBehaviour {
    public float minRandom;
    public float maxRandom;
    GameObject  attacker;
    public GameObject[] attackers;
    bool spawn = true;

    
   IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minRandom, maxRandom));
            spawnAttacker();
        }
    }
    private void spawnAttacker()
    {
        attacker = attackers[Random.Range(0,2)] ;   
        Instantiate(attacker,transform.position,transform.rotation); 
    }

}
