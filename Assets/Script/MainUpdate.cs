using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUpdate : MonoBehaviour
{
    public Text textVague;
    public GameData GameInfo;

    void Start()
    {
        GameInfo.VagueActuel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textVague.text = GameInfo.VagueActuel.ToString("0");
    }
}
