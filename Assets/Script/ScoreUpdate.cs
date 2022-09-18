using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text textPB;
    public Text textVague;
    public GameData GameInfo;

    void CheckCursorUnLock()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        textPB.text = GameInfo.VaguePB.ToString("0");
        textVague.text = GameInfo.VagueActuel.ToString("0");
        CheckCursorUnLock();
    }

    // Update is called once per frame
    void Update()
    {
        textPB.text = GameInfo.VaguePB.ToString("0");
        textVague.text = GameInfo.VagueActuel.ToString("0");
        CheckCursorUnLock();
    }
}
