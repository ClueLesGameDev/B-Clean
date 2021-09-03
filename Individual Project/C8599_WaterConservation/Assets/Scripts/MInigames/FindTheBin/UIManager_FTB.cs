using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_FTB : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreField;
   
    [SerializeField]
    private GameObject[] lifeField = new GameObject[3];

    [SerializeField]
    private GameObject finalScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreField.GetComponent<Text>().text = MainGame_FTB.score + "";
        if (MainGame_FTB.life == 2)
        {
            lifeField[0].SetActive(false);
        }
        if (MainGame_FTB.life == 1)
        {
            lifeField[1].SetActive(false);
        }
        if (MainGame_FTB.life == 0)
        {
            lifeField[2].SetActive(false);
            finalScore.SetActive(true);
            GameObject.Find("ScoreDisplay").transform.Find("Text").gameObject.GetComponent<Text>().text = MainGame_FTB.score + "";
        }

    }
}
