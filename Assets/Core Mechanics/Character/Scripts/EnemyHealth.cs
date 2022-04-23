using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int counter;
    public GameObject Pickup;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            counter += 1;
        }
        if (counter == 3) {
            Instantiate(Pickup, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
