using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static bool CTW_isUnlocked = false;
    public static bool STG_isUnlocked = false;
    public static bool FTB_isUnlocked = false;

    public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlocked_CTW()
    {
        if (CTW_isUnlocked == false)
        {
            popup.GetComponent<Text>().text = "Finish the first level with 80% water remaining to unlock";
            popup.SetActive(true);
        }
        else { SceneManager.LoadScene("DirtyDishes", LoadSceneMode.Single); }
    }

    public void Unlocked_STG()
    {
        if (STG_isUnlocked == false)
        {
            popup.GetComponent<Text>().text = "Finish the second level with 50% water remaining to unlock";
            popup.SetActive(true);
        }
        else { SceneManager.LoadScene("CatchThatDrop", LoadSceneMode.Single); }
    }

    public void Unlocked_FTB()
    {
        if (FTB_isUnlocked == false)
        {
            popup.GetComponent<Text>().text = "Finish the first level in 45 seconds to unlock";
            popup.SetActive(true);
        }
        else { SceneManager.LoadScene("SpotThatGerm", LoadSceneMode.Single); }
    }
}
