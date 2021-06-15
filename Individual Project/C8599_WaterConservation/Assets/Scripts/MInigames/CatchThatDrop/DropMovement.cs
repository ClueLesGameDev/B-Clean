using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMovement : MonoBehaviour
{
   
  
    void Update()
    {
        
        transform.Translate(Vector3.down * GameManager.speed * Time.deltaTime);

        if(transform.position.y < -140)
        {
            GameManager.life--;
            Destroy(this.gameObject);
            Destroy(this);
        }

    }

   
}
