using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile , gun;
    private Animator animate;
    void Start()
    {
        animate = GetComponent<Animator>();
    }

    void fire()
    {
        GameObject NewProjectile = Instantiate(projectile);
        NewProjectile.transform.position = gun.transform.position;

    }

}
