using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
        public GameObject player;
        public GameObject playerRootCamera;

        public GameObject ship;
        public GameObject shipRootCamera;
        
        public GameObject TeleportPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Boat") {
            Debug.Log("Entered Trigger");
                    ship.SetActive(false);
                    shipRootCamera.SetActive(false);
                    player.SetActive(true);
                    player.transform.position = TeleportPosition.transform.position;
                    playerRootCamera.SetActive(true);
                    player.SetActive(false);
                    player.SetActive(true);
             }
            Debug.Log("Pressed E");
           
    }

   
}
