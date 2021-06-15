using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject drop;
    public static int life = 3;
    public static int limit = 5;
    public static float speed = 30;
    float dropTime = 3.0f;

    void Start()
    {
        Instantiate(drop, new Vector3(Random.Range(-260, 260), 230, 0), Quaternion.identity);
        StartCoroutine(DropFall());
    }

    IEnumerator DropFall()
    {
        yield return new WaitForSeconds(dropTime);
        Instantiate(drop, new Vector3(Random.Range(-330, 330), 270, 0), Quaternion.identity);
        StartCoroutine(DropFall());
    }

    void Update()
    {
        if (PlayerMovement.score > limit)
        {
            speed += 5;
            if(dropTime > 1.0f)
            {
                dropTime -= 0.2f;
            }
            else
            {
                dropTime = 1.0f; 
            }
            limit += 5;
        }

        if(life == 0)
        {
            Time.timeScale = 0;
        }
      
    }

}
