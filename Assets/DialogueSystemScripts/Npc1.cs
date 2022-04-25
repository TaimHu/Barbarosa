using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Npc1 : MonoBehaviour
{
    public GameObject triggerText;
    public GameObject DialogueObject;
    public FirstPersonController rigid;


    void Start()
    {
        DialogueObject.SetActive(false); 
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggerText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                other.gameObject.GetComponent<PlayerData>().DialogueNumber = 1;
                DialogueObject.SetActive(true);
                rigid.enabled = false;
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                UnityEngine.Cursor.visible = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        DialogueObject.SetActive(false);
        triggerText.SetActive(false);
    }
}
