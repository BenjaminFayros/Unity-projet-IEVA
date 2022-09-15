using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerShoot : MonoBehaviour
{

    public static Action shootInput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)){
            shootInput.Invoke();
        }
    }
}
