using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstreMovement : MonoBehaviour
{
    public float Distance;
    public Transform player;
    public int distanceDeSpawn=0;
    public GameObject monstrePrefab;
    public float spawnRate=5f;
    public GameData GameInfo;
    
    private float nextSpawn;
    private int nbPrebs;
    
    void Update()
    {
        Distance=Vector3.Distance(transform.position,player.position);
        if(Distance<distanceDeSpawn)
        {
            if(Time.time>nextSpawn && GameInfo.VagueActuel <= GameInfo.VagueMax)
            { 
                GameInfo.VagueActuel ++;
                nbPrebs = GameInfo.VagueActuel;
                nextSpawn=Time.time+spawnRate;
                for(int i=0;i<nbPrebs;i++)
                {
                     Instantiate(monstrePrefab,transform.position,Quaternion.identity);
                }
            }
        }
    }
}
