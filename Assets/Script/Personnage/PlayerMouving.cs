using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouving : MonoBehaviour
{
    public float Speed = 0.01f;
    public bool allowCursorMove = true;

    void CheckCursorLock()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
 
    }
    // Start is called before the first frame update
    void Start()
    {
        CheckCursorLock();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)){
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z)){
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }

        float MouseX = Input.GetAxis("Mouse X") * 180.0f * Time.deltaTime ;

        transform.Rotate(Vector3.up * MouseX);
    }
}
