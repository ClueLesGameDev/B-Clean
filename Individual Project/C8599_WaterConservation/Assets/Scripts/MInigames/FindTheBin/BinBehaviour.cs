using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        string myTag = gameObject.tag;
        if (myTag == collision.tag)
        {
            MainGame_FTB.score++;
            collision.gameObject.SetActive(false);
        }
        else
        {
            //play music
        }
    }
}
