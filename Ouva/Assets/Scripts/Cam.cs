using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private float x_cam = 3f;
    private float y_cam = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //マウスカーソルの非表示
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x_mouse = Input.GetAxis("Mouse X");
        float y_mouse = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += x_mouse * x_cam;
        transform.localEulerAngles = newRotation;
        newRotation.x -= y_mouse * y_cam;
        transform.localEulerAngles = newRotation;
    }
}
