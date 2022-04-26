using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{ public GameObject player;
        public GameObject playerRootCamera;

        public GameObject ship;
        public GameObject shipRootCamera;
        
        public GameObject ShipTeleport;

         public GameObject TeleportPosition;

         public GameObject collider;
        
        public int state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

      private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player") {
            Debug.Log("Entered Trigger");
            collider.SetActive(false);
                    player.SetActive(false);
                    playerRootCamera.SetActive(false);
                    ship.SetActive(true);
                    TeleportPosition.SetActive(false);
                    ship.transform.position = ShipTeleport.transform.position;
                    // Vector3(17.3867035f,-31.758522f,43.7970467f);
                    //s.transform.position = new Vector3(0f,0f,0f);
                    shipRootCamera.SetActive(true);
                    
                    
                   
            
             }
            Debug.Log("Pressed E");
           
    }
}
