using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame_CW : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Dirt = new GameObject[15];

    public static int dirtCount = 15;
    int waterPercentage;
    
    // Start is called before the first frame update
    void Start()
    {
        waterPercentage = MainGame.waterPercentage;
    }

    // Update is called once per frame
    void Update()
    {
        if (waterPercentage == 0)
        {
            Debug.Log("Game Over");
        }

        if (dirtCount == 0 && waterPercentage > 0)
        {
            if (Countdown.minute < 1.0)
            {
                Debug.Log("bonus unlocked");
            }

            Debug.Log("you won");

        }

    }
}
