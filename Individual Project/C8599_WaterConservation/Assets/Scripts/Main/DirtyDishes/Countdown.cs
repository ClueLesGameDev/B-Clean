using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private float milliSecond;
    public static int second;
    public static int minute;
   
 


    void Update()
    {
        milliSecond += Time.deltaTime * 10;
        if (milliSecond > 9)
        {
            milliSecond = 0;
            second++;
        }


        if (second >= 60)
        {
            second = 0;
            minute++;
        }

    }
}
