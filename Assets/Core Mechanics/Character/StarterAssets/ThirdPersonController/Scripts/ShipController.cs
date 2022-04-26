using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
        public GameObject text;

        public GameObject player;
        public GameObject playerRootCamera;

        public GameObject ship;
        public GameObject shipRootCamera;

        public GameObject DummyShip;
        
        
        
        bool isInsideTrigger = false;
    // Start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInsideTrigger == true){
                DummyShip.SetActive(false);
                ship.SetActive(true);
                shipRootCamera.SetActive(true);
                player.SetActive(false);
                playerRootCamera.SetActive(false);
                 ship.SetActive(false);
                  ship.SetActive(true);
        }
    }

      private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player") {
            Debug.Log("Entered Trigger");
             text.SetActive(true);
                isInsideTrigger = true;
             }
            Debug.Log("Pressed E");
           
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            isInsideTrigger = false;
          Debug.Log("Exited");
        }
    }

}
