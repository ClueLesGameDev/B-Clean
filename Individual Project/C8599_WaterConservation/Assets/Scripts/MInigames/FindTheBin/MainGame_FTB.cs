using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame_FTB : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Wastes = new GameObject[15];
   
   // int limit = 10;
    float spawnTime = 4.0f;
    void Start()
    {
        StartCoroutine(SpawnWaste());
    }

    IEnumerator SpawnWaste()
    {
        int waste = Random.Range(0, 15);
        Instantiate(Wastes[waste], new Vector3(Random.Range(-200, 200), Random.Range(-75, -135), 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(SpawnWaste());
    }

    // Update is called once per frame
    void Update()
    {
       /* if(score > limit)
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
        }*/

    }
}

