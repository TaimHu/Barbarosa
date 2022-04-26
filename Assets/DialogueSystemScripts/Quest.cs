using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quest : MonoBehaviour
{
    public GameObject questUI1;
    public TextMeshProUGUI showQuest1;
    public GameObject questUI2;
    public TextMeshProUGUI showQuest2;
    private int questKillCount = 0;
    public int tempKills = 0;
    private int sonCount = 0;
    private int state = 0;
    bool enteredQuest1 = false;
    bool alreadyPlayedQuest1 = false;
    bool enteredQuest2 = false;
    bool alreadyPlayedQuest2 = false;

    //  public AudioClip sound;
    // private AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        showQuest1.text = " ";
        questUI1.SetActive(false);
        showQuest2.text = " ";
        questUI2.SetActive(false);
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
        if (other.tag == "Player" && !alreadyPlayedQuest2 && !enteredQuest2 && state == 1)
        {
            showQuest1.text = " ";
            questUI2.SetActive(true);
            showQuest2.text = " ";
            // audio.PlayOneShot(sound, 5);
            alreadyPlayedQuest2 = true;
            enteredQuest2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && state == 0) {
            //  Destroy(showQuest);
            Destroy(questUI1);
            showQuest1.text = "Task 1 Activated -\nEnemies Killed: " + questKillCount.ToString() + "/4";
        }
        if (other.tag == "Player" && state == 1)
        {
            //  Destroy(showQuest);
            Destroy(questUI2);
            showQuest1.text = "Task 2 Activated -\nEnemies Killed: " + questKillCount.ToString() + "/4\n" + 
                "Find Sidd's Son: " + sonCount.ToString() + "/1";
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tempKills != questKillCount)
        {
            questKillCount = tempKills;
            showQuest1.text = "Task 1 Activated -\nEnemies Killed: " + questKillCount + "/4";
        }
        if (questKillCount == 4) {
            showQuest1.text = "Return to Villager Sidd!";
            state++;
            tempKills = 0;
            questKillCount = 0;
            Debug.Log(tempKills);
        }
    }
}
