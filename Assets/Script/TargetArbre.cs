using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetArbre : MonoBehaviour, IDamageable
{
    public float health = 1f;
    public GameObject Arbre;

    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0){
            Arbre.transform.Translate(0f,-1.5f,0f);
            Arbre.transform.Rotate(90.0f,0f,45f);
            health=10000000;
        }
    }
}
