using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame_CW : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Dirt = new GameObject[15];
    public GameObject winPopup;

    public static int dirtCount = 15;
    public static int waterPercentage_CW;
    public static bool tapOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        waterPercentage_CW = MainGame.waterPercentage;
    }

    // Update is called once per frame
    void Update()
    {
        if (waterPercentage_CW == 0)
        {
            Debug.Log("Game Over");
        }

        if (dirtCount == 0 && waterPercentage_CW > 0)
        {
            if (waterPercentage_CW > 50)
            {
                Debug.Log("bonus unlocked");
                MenuManager.STG_isUnlocked = true;
            }

            Debug.Log("you won");

            winPopup.SetActive(true);
        }

    }

    public void LoadNext()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void TapOpen()
    {
        tapOpen = true;
        StartCoroutine(CountdownTimer());

    }

    public void TapClose()
    {
        tapOpen = false;
    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(2.0f);
        waterPercentage_CW--;
        if(tapOpen ==  true)
        {
            StartCoroutine(CountdownTimer());
        }
        
    }
}
