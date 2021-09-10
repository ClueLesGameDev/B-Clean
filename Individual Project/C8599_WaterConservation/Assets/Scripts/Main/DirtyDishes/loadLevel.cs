using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void loadDirtyDishes()
    {
        SceneManager.LoadScene("DirtyDishes", LoadSceneMode.Single);
    }

   /* public void loadCatchThatDrop()
    {
        SceneManager.LoadScene("CatchThatDrop", LoadSceneMode.Single);
    }

    public void loadSpotThatGerm()
    {
        SceneManager.LoadScene("SpotThatGerm", LoadSceneMode.Single);
    }*/
}
