using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public GameObject player;
    public Camera playerCam;
    public static int waterPercentage = 100;
    private int dirtyPlates = 9;
    public bool tapOpen;
    public GameObject switchPopup;

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
                    if(hitInfo.transform.gameObject.tag == "Collectible")
                    {
                        CollectPlates();
                        Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                        //popup.SetActive(true);
                    }
                }
               
            }

        }
        if (player.transform.position.x < -250 && player.transform.position.z >= 250)
        {
            switchPopup.SetActive(true);
        }
        else
            switchPopup.SetActive(false);

        if (waterPercentage == 0)
        {
            Debug.Log("Game Over");
        }

        if (dirtyPlates == 0 && waterPercentage > 0)
        {
            if(Countdown.minute < 1.0)
            {
                Debug.Log("bonus unlocked");
            }
       
            Debug.Log("you won");
           
        }
    }

    public void TapOpen()
    {
        tapOpen = true;
        StartCoroutine(CountdownTimer());

    }

    public void TapClose()
    {
        tapOpen = false;


    }

    public void CleanPlates()
    {
        dirtyPlates--;
    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(1.0f);
        waterPercentage--;

        if (tapOpen == true)
        {
            StartCoroutine(CountdownTimer());
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
