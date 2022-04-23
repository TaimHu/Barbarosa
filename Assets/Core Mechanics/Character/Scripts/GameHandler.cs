using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public HealthBar healthBar;
    private HealthSystem healthSystem;
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Ammo;

    private void Start()
    {
        healthSystem = new HealthSystem(100);
        healthBar.Setup(healthSystem);
        Debug.Log("Health: " + healthSystem.getHealth());
        Debug.Log("Health: " + healthSystem.getHealthPercent());
        healthSystem.Damage(50);
        Debug.Log("Health: " + healthSystem.getHealth());
        Debug.Log("Health: " + healthSystem.getHealthPercent());
        var script = gameObject.GetComponent<ThirdPersonShooterController>();
        Health.text = "Health: " + (healthSystem.getHealthPercent() * 200).ToString();
        Ammo.text= "Ammo: " + script.getAmmo().ToString();
       /* healthSystem.Heal(1231);
        Debug.Log("Health: " + healthSystem.getHealth());
        Debug.Log("Health: " + healthSystem.getHealthPercent());*/
    }
    private void OnTriggerEnter(Collider other)
    {
        var script = gameObject.GetComponent<ThirdPersonShooterController>();
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            //Destroy(gameObject);
            healthSystem.Damage(10);
            Debug.Log("Player got hit");
            Health.text = "Health: " + (healthSystem.getHealthPercent() * 200).ToString();
            Ammo.text = "Ammo: " + script.getAmmo().ToString();
        }

        if (other.gameObject.CompareTag("Pickup")) {
            healthSystem.Heal(50);
            Debug.Log("Caught the pickup");
            Destroy(other.gameObject);
            script.setAmmo(20);
            Health.text = "Health: " + (healthSystem.getHealthPercent() * 200).ToString();
            Ammo.text= "Ammo: " + script.getAmmo().ToString();
        }
    }

}
