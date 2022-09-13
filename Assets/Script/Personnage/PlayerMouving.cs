using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouving : MonoBehaviour
{
    public float Speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        //Mouse.x += Input.GetAxis("Mouse X");
        //Mouse.z += Input.GetAxis("Mouse Y");

        //transform.position = Vector3.Slerp(transform.position, Mouse, 0.0f);

        // probleme : j'ai une position Vector3 et pas un quaternion et je ne sais pas comment 
        // transform.localRotation = Quaternion.Slerp(Mouse, transform.rotation, 0.0f);
    }
}
