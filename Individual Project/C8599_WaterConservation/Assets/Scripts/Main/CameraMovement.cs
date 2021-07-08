using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static int movCam = 1;
    float speed = 100.0f;

    float rotVal = 2.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;


    private void Update()
    {
        if(movCam == 1)
        {

            yaw += rotVal * Input.GetAxis("Mouse X");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        if(transform.position.z > 300)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 300);
            
        }
        if (transform.position.z < -500)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -500);

        }
        if (transform.position.x < -470)
        {
            transform.position = new Vector3(-470, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 470)
        {
            transform.position = new Vector3(470, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);

    }


}
