using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouving : MonoBehaviour
{
    public float Speed = 0.01f;
    public Vector2 turn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixUpdate()
    {
        if (Input.GetKey(KeyCode.Z)){
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q)){
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0 , , 0);
    }
}
