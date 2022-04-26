using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quest : MonoBehaviour
{
    public GameObject questUI1;
    public TextMeshProUGUI showQuest1;
    public int quest1KillCount = 0;
    private int temp = 0;
    private int state = 0;
    bool enteredQuest1 = false;
    bool alreadyPlayedQuest1 = false;

  //  public AudioClip sound;
   // private AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        showQuest1.text = " ";
        questUI1.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !alreadyPlayedQuest1 && !enteredQuest1 && state == 0) {
            questUI1.SetActive(true);
            showQuest1.text = " ";
            // audio.PlayOneShot(sound, 5);
            alreadyPlayedQuest1 = true;
            enteredQuest1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            //  Destroy(showQuest);
            Destroy(questUI1);
            showQuest1.text = "Task 1 Activated -\nEnemies Killed: " + quest1KillCount.ToString() + "/4";
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (temp != quest1KillCount)
        {
            showQuest1.text = "Task 1 Activated -\nEnemies Killed: " + quest1KillCount + "/4";
            temp = quest1KillCount;
        }
        if (quest1KillCount == 4) {
            showQuest1.text = "Return to Villager Sidd!";
        }
    }
}
