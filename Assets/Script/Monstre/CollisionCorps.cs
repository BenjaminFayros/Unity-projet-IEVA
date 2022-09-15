using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCorps : MonoBehaviour
{
    public GameObject Player;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ennemy")){
            Destroy(Player);
        }
    }
}
