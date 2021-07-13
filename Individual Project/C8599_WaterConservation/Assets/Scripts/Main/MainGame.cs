using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainGame : MonoBehaviour
{
    public GameObject player;
    public Camera playerCam;
    public static int waterPercentage = 100;
    public bool tapOpen;
    public GameObject switchPopup;

    public static int platecount = 0;
    public static int dirtyPlates = 15;
    public static int cleanPlates = 0;
    private void Update()
    {
        if(platecount < 0)
        {
            platecount = 0;
        }
        //collecting plates
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo = new RaycastHit();

            bool isHit = Physics.Raycast(playerCam.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (isHit)
            {
                {
                    if (hitInfo.transform.gameObject.tag == "Collectible")
                    {
                        CollectPlates(hitInfo.transform.gameObject);
                        Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                    }
                }

            }

        }
        
        //switch activation
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

    IEnumerator CleanPlates()
    {
        yield return new WaitForSeconds(1.5f);
        dirtyPlates--;
        cleanPlates++;
        platecount--;
    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(5.0f);
        waterPercentage--;

        if (tapOpen == true)
        {
            StartCoroutine(CleanPlates());
            StartCoroutine(CountdownTimer());
        }

    }
    public void CollectPlates(GameObject onHold)
    {
       if (platecount >= 3)
        {
            Debug.Log("limit");
            return;
        }
        onHold.SetActive(false);
        platecount++;
    }
         
}
