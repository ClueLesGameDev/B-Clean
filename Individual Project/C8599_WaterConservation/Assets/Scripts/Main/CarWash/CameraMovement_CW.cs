using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement_CW : MonoBehaviour
{
    public float speed = 3.5f;
    private float X;
    private float Y;

    float scrollSpeed = 2000;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Vector3 tempPos = transform.position;

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
            //X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, Y, 0);
        }

        //tempPos.z += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * 10 * Time.deltaTime;

        tempPos.z = Mathf.Clamp(tempPos.z, -580, -125);

        //transform.position = tempPos;
        transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * 10 * Time.deltaTime);

        if (transform.position.x < -470)
        {
            transform.position = new Vector3(-470, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 470)
        {
            transform.position = new Vector3(470, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 780)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 780);
        }
    }
}
