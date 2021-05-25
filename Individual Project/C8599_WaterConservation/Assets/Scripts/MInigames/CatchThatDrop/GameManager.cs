using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject drop;
    public static int life = 3;
    public static int limit = 5;
    public static float speed = 30;

    void Start()
    {
        Instantiate(drop, new Vector3(Random.Range(-260, 260), 230, 0), Quaternion.identity);
        StartCoroutine(DropFall());
    }

    IEnumerator DropFall()
    {
        yield return new WaitForSeconds(3.0f);
        Instantiate(drop, new Vector3(Random.Range(-260, 260), 230, 0), Quaternion.identity);
        StartCoroutine(DropFall());
    }

    void Update()
    {
        if (PlayerMovement.score > limit)
        {
            speed += 15;
            limit += 5;
        }
    }

}
