using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstreMovement : MonoBehaviour
{
    public float Distance;
    public int maxSpawn= 3;
    public bool reSpawn;
    public Transform player;
    public int distanceDeSpawn=0;
    public GameObject monstrePrefab;
    public float spawnRate=3f;
    
    private float nextSpawn;
    private int nbPrebs;
    private int Nr;

    
    void Update()
    {
        Distance=Vector3.Distance(transform.position,player.position);
        if(Distance<distanceDeSpawn && Nr< maxSpawn)
        {
            if(Time.time>nextSpawn)
            { 
                nextSpawn=Time.time+spawnRate;
                GameObject obj= Instantiate(monstrePrefab,transform.position,Quaternion.identity) as GameObject;
                obj.name = "M"+this.name;
                Nr++;

            }
        }
        if(reSpawn)
        {
            nbPrebs=0;
            foreach (GameObject item in FindObjectsOfType(typeof(GameObject)) as GameObject[])
            {
                if(item.name=="M"+this.name)
                {
                    nbPrebs++;
                }
            }
            if(nbPrebs<maxSpawn)
            {
                Nr=nbPrebs;
            }
        }

    }

   
}
