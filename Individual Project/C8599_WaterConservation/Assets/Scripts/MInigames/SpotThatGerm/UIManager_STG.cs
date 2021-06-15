using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_STG : MonoBehaviour
{
    [SerializeField]
    public GameObject Score;
    [SerializeField]
    private GameObject[] life = new GameObject[3];

    public GameObject finalScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.GetComponent<Text>().text = GameManger.score + "";
        if (GameManger.life == 2)
        {
            life[0].SetActive(false);
        }
        if (GameManger.life == 1)
        {
            life[1].SetActive(false);
        }
        if (GameManger.life == 0)
        {
            life[2].SetActive(false);
            finalScore.SetActive(true);
            GameObject.Find("ScoreDisplay").transform.Find("Text").gameObject.GetComponent<Text>().text = GameManger.score + "";
        }
    }
}
