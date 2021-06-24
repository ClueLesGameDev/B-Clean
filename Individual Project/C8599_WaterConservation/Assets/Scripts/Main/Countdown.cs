using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float milliSecond;
    int second;
    int minute;
   
    [SerializeField]
    private GameObject secDisp;
    [SerializeField]
    private GameObject minDisp;


    void Update()
    {
        milliSecond += Time.deltaTime * 10;
        if (milliSecond > 9)
        {
            milliSecond = 0;
            second++;
        }

        if (second < 10) { secDisp.GetComponent<Text>().text = "0" + second + "" ; }

        else { secDisp.GetComponent<Text>().text = second + "" ; }

        if (second >= 60)
        {
            second = 0;
            minute++;
        }


        if (minute < 10) { minDisp.GetComponent<Text>().text = "0" + minute + "" + ":"; }

        else { minDisp.GetComponent<Text>().text = minute + "" + ":"; }

    }
}
