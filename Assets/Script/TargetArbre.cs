using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetArbre : MonoBehaviour, IDamageable
{
    public float health = 1f;

    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0){
            //Transform.rotation(0,90,0);
            health=10000000;
        }
    }
}
