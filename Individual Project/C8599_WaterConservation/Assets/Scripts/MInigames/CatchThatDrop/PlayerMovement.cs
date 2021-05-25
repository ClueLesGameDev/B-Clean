using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour 
{
    private Vector3 offset;
    Vector3 camCord;
    public static int score = 0;
   
    public void OnMouseDown()
    {
        camCord = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = camCord.z;

        return Camera.main.WorldToScreenPoint(mousePoint);
    }

    public void OnMouseDrag()
    {
        transform.position = new Vector3(GetMouseWorldPos().x + offset.x, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectible")
        {
            score++;
            //Debug.Log(score);
            Destroy(collision.gameObject);
        }
    }
}
