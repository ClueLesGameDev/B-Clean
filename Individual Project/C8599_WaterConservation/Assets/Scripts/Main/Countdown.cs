using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    private int timeRemaining = 25;
    [SerializeField]
    private GameObject timeField;

    void Start()
    {
        timeField.GetComponent<Text>().text = timeRemaining + "";
        StartCoroutine(CountdownTimer());

    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(1.0f);
        timeRemaining--;
        timeField.GetComponent<Text>().text = timeRemaining + "";
        if(timeRemaining == 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            StartCoroutine(CountdownTimer());
        }
       
    }
}
