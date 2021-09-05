using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame_CW : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Dirt = new GameObject[15]; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hitInfo = new RaycastHit2D();

            bool isHit = Physics2D.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (isHit)
            {
                {
                    //if (hitInfo.transform.gameObject.tag == "Collectible")
                    //{
                       // CollectPlates(hitInfo.transform.gameObject);
                        Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                    //}
                }

            }



        }

    }
}
