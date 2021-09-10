using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtBehaviour : MonoBehaviour
{
    [SerializeField]
    private AudioSource killAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if(MainGame_CW.tapOpen == true)
        {
            MainGame_CW.dirtCount--;
            GetComponent<Animator>().enabled = true;
            killAudio.Play();
            StartCoroutine(Die());
        }
        
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
    }

}
