using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour {
    
    [Range(-1f,1f)]public float walkingSpeed;
    public float HitValue = 10f;
    private GameObject CurrentObjectTriggered;

	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime *walkingSpeed);
    }

    
    public float SetsSpeed(float speed)
    {
        walkingSpeed = speed;
        return walkingSpeed;
    }
    public void HitCurrentDefender(float Damage)
    {
        
            if (CurrentObjectTriggered)
            {
                Health health = CurrentObjectTriggered.GetComponent<Health>();
            if (health) { health.DamageDone(Damage); }
            }
        }
    
    public void Attack(GameObject collider)
    {
        CurrentObjectTriggered = collider;        
    }
}
