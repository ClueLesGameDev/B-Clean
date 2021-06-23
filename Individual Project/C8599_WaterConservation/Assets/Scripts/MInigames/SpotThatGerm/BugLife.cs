using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugLife : MonoBehaviour
{
    [SerializeField]
    private AudioSource killAudio;

    bool isKilled = false;
    void Start()
    {
        StartCoroutine(Die());
    }

   IEnumerator Die()
    {
        yield return new WaitForSeconds(2.0f);
        if(!isKilled)
        {
            GameManger.life--;
        }
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        GameManger.score++;
        GetComponent<Animator>().enabled = true;
        killAudio.Play();
        isKilled = true;
        StartCoroutine(Die());
       
    }

  
}
