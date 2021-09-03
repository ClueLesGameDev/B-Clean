using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame_FTB : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Wastes = new GameObject[15];

    public static float score = 0.0f;
    int limit = 10;
    float spawnTime = 4.0f;

    public static int life = 3;
    void Start()
    {
        StartCoroutine(SpawnWaste());
    }

    IEnumerator SpawnWaste()
    {
        int waste = Random.Range(0, 15);
        Instantiate(Wastes[waste], new Vector3(Random.Range(-325, 325), Random.Range(-140, -220), 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(SpawnWaste());
    }

    // Update is called once per frame
    void Update()
    {
       if(score > limit)
        {
            if(spawnTime < 0.8f)
            {
                spawnTime = 0.8f;
            }
            else
            {
                spawnTime -= 0.2f;
            }
            limit += 10;
        }

        if (life == 0)
        {
            Time.timeScale = 0;
        }

    }
}

