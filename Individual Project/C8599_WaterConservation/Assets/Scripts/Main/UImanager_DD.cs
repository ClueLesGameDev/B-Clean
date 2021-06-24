using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevel : MonoBehaviour
{
    private int waterPercentage = 100;
    [SerializeField]
    private GameObject waterField;
    private int dirtyPlates = 9;
    public bool tapOpen;

    void Start()
    {
        waterField.GetComponent<Text>().text = waterPercentage + "%";
        tapOpen = false;
    }

    void Update()
    {
        if (waterPercentage == 0)
        {
            Debug.Log("Game Over");
        }

        if (dirtyPlates == 0)
        {
             if (waterPercentage > 45)
             {
                Debug.Log("you won");
                Debug.Log("You got a bonus card");
             }
             else
             {
                Debug.Log("you won");
             }
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
        waterField.GetComponent<Text>().text = waterPercentage + "";
        
        if (tapOpen == true)
        {
            StartCoroutine(CountdownTimer());
        }

    }
}
