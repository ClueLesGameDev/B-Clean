using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public Camera playerCam;
    //public GameObject popup;

    int platecount = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            
            bool isHit = Physics.Raycast(playerCam.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (isHit)
            {
                {
                    if(hitInfo.transform.gameObject.tag == "MovableObj")
                    {
                        CollectPlates();
                        Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                        //popup.SetActive(true);
                    }
                }
               
            }

        }
    }

    public void CollectPlates()
    {
       if (platecount > 3)
        {
            Debug.Log("limit");
            return;
        }
        platecount++;
        Debug.Log(platecount);
    }
         
}
