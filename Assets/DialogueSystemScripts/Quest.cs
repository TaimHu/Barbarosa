using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public GameObject questUI1;
    public GameObject showQuest1;

    bool entered = false;
    bool alreadyPlayed = false;

  //  public AudioClip sound;
   // private AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        showQuest1.SetActive(false);
        questUI1.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !alreadyPlayed && !entered) {
            questUI1.SetActive(true);
           
           // audio.PlayOneShot(sound, 5);
            alreadyPlayed = true;
            entered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            //  Destroy(showQuest);
            Destroy(questUI1);
            showQuest1.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
