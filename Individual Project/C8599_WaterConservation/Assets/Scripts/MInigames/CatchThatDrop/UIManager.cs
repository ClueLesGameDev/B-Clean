using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] life = new GameObject[3];

    [SerializeField]
    private GameObject score;
    [SerializeField]
    private GameObject finalScore;
    void Update()
    {
        score.GetComponent<Text>().text = PlayerMovement.score + "";
        if(GameManager.life == 2)
        {
            life[0].SetActive(false);
        }
        if (GameManager.life == 1)
        {
            life[1].SetActive(false);
        }
        if (GameManager.life == 0)
        {
            life[2].SetActive(false);
            finalScore.SetActive(true);
            GameObject.Find("ScoreDisplay").transform.Find("Text").gameObject.GetComponent<Text>().text = PlayerMovement.score + "";
        }
    }
}
