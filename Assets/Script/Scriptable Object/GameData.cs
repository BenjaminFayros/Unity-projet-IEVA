using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Game", menuName="Game/Data")]

public class GameData : ScriptableObject
{
    public new string name;

    public int VagueMax;
    public int VagueActuel;
    public int VaguePB;
}