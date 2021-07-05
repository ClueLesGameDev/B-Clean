using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float speed = 100.0f;

    float rotVal = 2.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;


    private void Update()
    {
        
        if(transform.position.z > 300)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 300);
            
        }
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        yaw += rotVal * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }


}
