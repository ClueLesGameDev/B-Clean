using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteSpawner : MonoBehaviour
{
    private Vector3 offset;
    Vector3 camCord;
    
    void Start()
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(3.0f);
        MainGame_FTB.life--;
        Debug.Log(MainGame_FTB.life);
        Destroy(gameObject);
    }

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
        transform.position = new Vector3(GetMouseWorldPos().x + offset.x, GetMouseWorldPos().y + offset.y, transform.position.z);
    }

    
}
