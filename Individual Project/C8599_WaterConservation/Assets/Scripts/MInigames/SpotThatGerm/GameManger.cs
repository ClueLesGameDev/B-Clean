using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Bugs = new GameObject[3];

    public static int score = 0;
    public static int life = 3;

    int limit = 10;
    float spawnTime = 2.0f;
    void Start()
    {
        StartCoroutine(SpawnBugs());
    }

    IEnumerator SpawnBugs()
    {
        int bug = Random.Range(0, 3);
        Instantiate(Bugs[bug], new Vector3(Random.Range(-300, 300), Random.Range(-200, 200), 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(SpawnBugs());
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
