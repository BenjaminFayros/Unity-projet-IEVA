using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionCorps : MonoBehaviour
{
    public GameObject Player;
    public GameData GameInfo;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ennemy")){
            Destroy(Player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
            if (GameInfo.VaguePB < GameInfo.VagueActuel){
                GameInfo.VaguePB = GameInfo.VagueActuel;
                
            }
        }
    }
}
